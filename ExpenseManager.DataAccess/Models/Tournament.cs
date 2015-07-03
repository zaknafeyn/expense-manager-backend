﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManager.DataAccess.Models
{
    public class Tournament
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; } 
        [Required]
        public string Name { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Place { get; set; } 
    }
}