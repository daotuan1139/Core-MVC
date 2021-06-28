using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_MVC.Services
{

    public interface IPersonService
    {
        List<Person> GetList();
        Person Create(Person member);
        Person Edit(Person member, string email);
        bool Delete(string email);
        Person Detail(string email);

    }

}