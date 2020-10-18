﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore3.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title é um campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Title deve ter no máximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Title deve ter no mínimo 3 caracteres")]
        [Column("title")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Descrição deve ter no máximo 1024 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Preço é um campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Categoria id é um campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "A categoria id deve ser maior que 0")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
