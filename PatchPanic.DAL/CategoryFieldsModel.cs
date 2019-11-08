using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatchPanic.DAL
{
    [Table("CategoryFields")]
    class CategoryFieldsModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [Column("CategoryId")]
        public Guid CategoryId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string TypeOf { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
