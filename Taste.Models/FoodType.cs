using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodHut.Models
{
    public class FoodType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Food Type Name")]
        public string Name { get; set; }
    }
}
