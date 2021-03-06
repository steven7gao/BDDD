﻿using System;
using System.Collections.Generic;
using NHibernate;

namespace BDDD.Repository.NHibernate
{
    public class NHibernateContext : INHibernateContext
    {
        #region 变量

        [ThreadStatic] private readonly DBSessionFactory databaseSessionFactory;
        [ThreadStatic] private readonly List<object> deletedObjects = new List<object>();
        [ThreadStatic] private readonly Guid id;
        [ThreadStatic] private readonly List<object> modifiedObjects = new List<object>();
        [ThreadStatic] private readonly List<object> newObjects = new List<object>();

        private readonly Dictionary<string, object> repositories = new Dictionary<string, object>();
        [ThreadStatic] private readonly ISession session;
        private readonly object sync = new object();
        [ThreadStatic] private bool committed = true;

        #endregion

        public NHibernateContext()
        {
            id = Guid.NewGuid();
        }

        public NHibernateContext(INHibernateConfiguration nhibernateConfig)
            : this()
        {
            databaseSessionFactory = new DBSessionFactory(nhibernateConfig.GetNHibernateConfiguration());
            session = databaseSessionFactory.Session;
        }

        public ISession Session
        {
            get { return session; }
        }

        public Guid ID
        {
            get { return id; }
        }

        public void RegisterNew(object obj)
        {
            newObjects.Add(obj);
            committed = false;
        }

        public void RegisterModified(object obj)
        {
            modifiedObjects.Add(obj);
            committed = false;
        }

        public void RegisterDeleted(object obj)
        {
            deletedObjects.Add(obj);
            committed = false;
        }

        public IRepository<TAggregateRoot> GetRepository<TAggregateRoot>() where TAggregateRoot : class
        {
            //约定大于配置，这里不再校验
            //为了api接口的美观，这里没有直接使用泛型约束TAggregateRoot一定要实现IAggregate接口
            //if (typeof(TAggregateRoot).GetInterface("IAggregateRoot", true) == null)
            //{
            //    throw new RepositoryException("聚合根必须实现IAggregateRoot接口");
            //}

            string key = typeof (TAggregateRoot).AssemblyQualifiedName;
            if (repositories.ContainsKey(key))
            {
                return repositories[key] as IRepository<TAggregateRoot>;
            }
            else
            {
                //todo:unity不支持泛型注册，所以这里如果使用GetService的话具体类型的注册就会很多
                var repository = new NHibernateRepository<TAggregateRoot>(this);
                    //ServiceLocator.Instance.GetService<IRepository<TAggregateRoot>>(); 
                lock (sync)
                {
                    repositories.Add(key, repository);
                }
                return repository;
            }
        }

        public bool Committed
        {
            get { return committed; }
        }

        public void Commit()
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    foreach (object obj in newObjects)
                    {
                        session.Save(obj);
                    }
                    foreach (object obj in modifiedObjects)
                    {
                        session.Update(obj);
                    }
                    foreach (object obj in deletedObjects)
                    {
                        session.Delete(obj);
                    }
                    transaction.Commit();
                    newObjects.Clear();
                    deletedObjects.Clear();
                    modifiedObjects.Clear();
                    committed = true;
                }
                catch
                {
                    if (transaction.IsActive)
                        transaction.Rollback();
                    session.Clear();
                    throw;
                }
            }
        }

        public void Rollback()
        {
            committed = false;
        }

        public void Dispose()
        {
            ISession dbSession = session;
            if (dbSession != null && dbSession.IsOpen)
            {
                dbSession.Close();
            }
            dbSession.Dispose();
        }
    }
}