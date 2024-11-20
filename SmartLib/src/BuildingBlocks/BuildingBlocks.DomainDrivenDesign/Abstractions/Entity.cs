namespace BuildingBlocks.DomainDrivenDesign.Abstractions
{
    public class Entity<T> : IEntity<T>
    {
        public T Id { get; set; } = default!;
        public DateTime? CreatedAt { get; set; } = default!;
        public string? CreatedBy { get; set; } = default!;
        public DateTime? LastModifiedAt { get; set; } = default!;
        public string? LastModifiedBy { get; set; } = default!;
    }
}
