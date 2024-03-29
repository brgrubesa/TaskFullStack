﻿using System.ComponentModel.DataAnnotations;

namespace TaskFullStack.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
