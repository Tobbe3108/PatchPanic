using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PatchPanic.IBL;

namespace PatchPanic.DAL
{
    class CategoryField : ICategoryField
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column("CategoryId")]
        public Guid CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int TypeOf { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
