using System;
using System.ComponentModel.DataAnnotations;

namespace WebMvc1.Models
{
    public class FormModel
    {
        [Display(Name = "Imie")]
        public string Name { get; set; }

        [Display(Name = "Data urodzenia")]
        public DateTime DateOfBirth { get; set; }

        public int Days { get; set; }
    }
}
