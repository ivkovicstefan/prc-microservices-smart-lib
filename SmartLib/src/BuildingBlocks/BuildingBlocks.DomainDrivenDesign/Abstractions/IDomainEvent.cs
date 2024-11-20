using MediatR;

namespace BuildingBlocks.DomainDrivenDesign.Abstractions
{
    public interface IDomainEvent : INotification
    {
        Guid EventId => Guid.NewGuid();
        public string OccuredOn => GetType().AssemblyQualifiedName ?? default!;
    }
}