using System;

namespace PatchPanic.IBL
{
    public interface IEntityEntry
    {
        Guid CategoryFieldId { get; set; }
        Guid EntityId { get; set; }
        Guid Id { get; set; }
        byte[] RowVersion { get; set; }
        string Value { get; set; }
    }
}