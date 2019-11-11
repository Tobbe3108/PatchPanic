using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PatchPanic.IBL;

namespace PatchPanic.DAL
{
    class Category : ICategory
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
