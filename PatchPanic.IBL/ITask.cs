using System;

namespace PatchPanic.IBL
{
    public interface ITask
    {
        Guid AssignedToId { get; set; }
        byte Completed { get; set; }
        Guid CreatedById { get; set; }
        string Deadline { get; set; }
        string Description { get; set; }
        Guid EntityId { get; set; }
        string Headline { get; set; }
        Guid Id { get; set; }
        int RecurringInterval { get; set; }
        byte[] RowVersion { get; set; }
    }
}