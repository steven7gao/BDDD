﻿namespace BDDD.Events
{
    public interface IDomainEvent<TKey> : IEvent<TKey>
    {
        IEntity<TKey> Source { get; set; }
        long Version { get; set; }
        long Branch { get; set; }
    }
}