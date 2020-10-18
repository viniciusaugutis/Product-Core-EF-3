using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore3.Models
{
    [Table("category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title é um campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Title deve ter no máximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Title deve ter no mínimo 3 caracteres")]
        [Column("title")]
        public string Title { get; set; }
    }
}
