﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace forthekittens.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [DisplayName("Category Name")]
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 10)]
        public int DisplayOrder { get; set; }

    }
}
