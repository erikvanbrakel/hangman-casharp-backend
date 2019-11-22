using System;
using HangmanBackend.Domain;

namespace HangmanBackend.Infrastructure
{
    public interface IRepository<TAggregate> where TAggregate : AggregateRoot
    {
        void Save(TAggregate aggregate);
        TAggregate Load(Guid streamId);
    }
}