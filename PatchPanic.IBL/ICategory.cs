using System;

namespace PatchPanic.IBL
{
    public interface ICategory
    {
        Guid Id { get; set; }
        string Name { get; set; }
        byte[] RowVersion { get; set; }
    }
}