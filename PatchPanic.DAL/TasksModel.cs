using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatchPanic.DAL
{
    [Table("Tasks")]
    class TasksModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Headline { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Deadline { get; set; }

        [Required]
        [Column("CreatedById")]
        public Guid CreatedById { get; set; }

        [Required]
        [Column("AssignedToId")]
        public Guid AssignedToId { get; set; }

        [Required]
        public byte Completed { get; set; }

        public int RecurringInterval { get; set; }

        [Column("EntityId")]
        public Guid EntityId { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
