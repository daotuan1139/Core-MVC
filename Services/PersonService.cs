using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Core_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_MVC.Services
{

    public class PersonService : IPersonService
    {
        private List<Person> listMember = new List<Person>();
        public List<Person> GetList()
        {
            return new List<Person>
            {
                new Person { FirstName = "Ngo", LastName = "Huy", Gender = true, DateOfBirth = new DateTime(1998, 06, 21), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 24, IsGradated = true , Email = "ngohuy98@gmail.com"},
                new Person { FirstName = "Tran", LastName = "Thuy", Gender = false, DateOfBirth = new DateTime(2001, 04, 11), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 25, IsGradated = false ,Email = "thuytran10@gmail.com"},
                new Person { FirstName = "Nguyen", LastName = "Phong", Gender = true, DateOfBirth = new DateTime(2001, 03, 11), Phone = 0329865444, BirthPlace = "Ha Tinh", Age = 27, IsGradated = false ,Email = "ngphong01@gmail.com"},
                new Person { FirstName = "Le", LastName = "Ha", Gender = false, DateOfBirth = new DateTime(2000, 03, 11), Phone = 0329865444, BirthPlace = "Ha Nam", Age = 20, IsGradated = false ,Email = "hale200@gmail.com"},
                new Person { FirstName = "Dao", LastName = "Tuan", Gender = true, DateOfBirth = new DateTime(1999, 03, 11), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 22, IsGradated = true ,Email = "daotuan1139@gmail.com"},
            };
        }
        public Person Create(Person member)
        {
            listMember.Add(member);
            return member;
        }
        public Person Edit(Person member, string email)
        {
            listMember.Find(x => x.Email == email);

            listMember.RemoveAll(p => p.Email == email);
            listMember.Add(member);
            return member;
        }
        public bool Delete(string email)
        {
            listMember.RemoveAll(p => p.Email == email);
            return true;
        }

        public Person Detail(string email)
        {
            
            return listMember.Find(x => x.Email == email);
        }


    }

}