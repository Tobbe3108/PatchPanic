using System;

namespace PatchPanic.IBL
{
    public interface ICategoryField
    {
        Guid CategoryId { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }
        byte[] RowVersion { get; set; }
        int TypeOf { get; set; }
    }
}