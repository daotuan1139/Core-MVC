using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Core_MVC.Models
{
    
    public class Person
    {

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Required]
        public bool? Gender { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Range(100000000,999999999)]
        public int Phone { get; set; }

        [Display(Name = "Birth Place")]
        public string BirthPlace { get; set; }
        public int Age { get; set; }

        [Display(Name = "Gradated")]
        public bool? IsGradated { get; set; }

        [Key]
        [Display(Name = "Email address")]
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

    
    }

}