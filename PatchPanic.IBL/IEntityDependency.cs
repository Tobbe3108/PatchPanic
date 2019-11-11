using System;

namespace PatchPanic.IBL
{
    public interface IEntityDependency
    {
        Guid EntityId { get; set; }
        Guid Id { get; set; }
        Guid ParentId { get; set; }
        byte[] RowVersion { get; set; }
    }
}