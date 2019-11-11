using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatchPanic.DAL
{
    class Entity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Column("CategoryId")]
        public Guid CategoryId { get; set; }

        [Required]
        public string LastCheckUp { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
