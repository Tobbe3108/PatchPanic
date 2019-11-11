using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatchPanic.DAL
{
    class EntityEntry
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column("EntityId")]
        public Guid EntityId { get; set; }

        [Required]
        [Column("CategoryFieldId")]
        public Guid CategoryFieldId { get; set; }

        [Required]
        public string Value { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
