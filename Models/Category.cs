﻿using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Título é obrigatório")]
        [MaxLength(50, ErrorMessage = "Título deve conter no máximo 50 caracteres")]
        [MinLength(5, ErrorMessage = "Título deve conter no mínimo 5 caracteres")]
        public string Title { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new();
    }
}
