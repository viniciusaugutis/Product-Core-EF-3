using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore3.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username é um campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Username deve ter no máximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Username deve ter no mínimo 3 caracteres")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Senha é um campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Senha deve ter no máximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Senha deve ter no mínimo 3 caracteres")]
        public string Password { get; set; }

        public string Role { get; set; }
    }
}
