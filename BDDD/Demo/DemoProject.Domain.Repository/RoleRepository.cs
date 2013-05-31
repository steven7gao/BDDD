﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDD.Repository;
using BDDD.Repository.NHibernate;
using DemoProject.Domain.Model;
using DemoProject.Domain.Repositories;

namespace DemoProject.Domain.Repository
{
    public class RoleRepository: NHibernateRepository<Role>,IRoleRepository
    {
        public RoleRepository(IRepositoryContext context) : base(context)
        {
        }
    }
}
