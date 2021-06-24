using System;
using Microsoft.AspNetCore.Mvc;

namespace Core_MVC.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Phone { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get; set; }
        public bool? IsGradated { get; set; }

        public Person() { }
        public Person(string FirstName, string LastName, Boolean Gender, DateTime DateOfBirth, int Phone, string BirthPlace, int Age, Boolean IsGradated)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Phone = Phone;
            this.BirthPlace = BirthPlace;
            this.Age = Age;
            this.IsGradated = IsGradated;
        }
    }

}