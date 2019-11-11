using System;

namespace PatchPanic.IBL
{
    public interface IEntity
    {
        Guid CategoryId { get; set; }
        Guid Id { get; set; }
        string LastCheckUp { get; set; }
        string Name { get; set; }
        byte[] RowVersion { get; set; }
    }
}