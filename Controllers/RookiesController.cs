using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;


namespace Core_MVC.Controllers
{
    public class Rookies : Controller
    {
        private Person db = new Person();


        public IActionResult listMember()
        {
            list.Add(new Person { FirstName = "Ngo", LastName = "Huy", Gender = true, DateOfBirth = new DateTime(1998, 06, 21), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 24, IsGradated = true });
            list.Add(new Person { FirstName = "Tran", LastName = "Thuy", Gender = false, DateOfBirth = new DateTime(2001, 04, 11), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 25, IsGradated = false });
            list.Add(new Person { FirstName = "Nguyen", LastName = "Phong", Gender = true, DateOfBirth = new DateTime(2001, 03, 11), Phone = 0329865444, BirthPlace = "Ha Tinh", Age = 27, IsGradated = false });
            list.Add(new Person { FirstName = "Le", LastName = "Ha", Gender = false, DateOfBirth = new DateTime(2000, 03, 11), Phone = 0329865444, BirthPlace = "Ha Nam", Age = 20, IsGradated = false });
            list.Add(new Person { FirstName = "Dao", LastName = "Tuan", Gender = true, DateOfBirth = new DateTime(1999, 03, 11), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 22, IsGradated = true });

            return View(list.ToList());
        }

        List<Person> list = new List<Person>();
        [Route("Nashtech/Rookies/Index")]
        public IActionResult Index()
        {
            listMember();
            return View();
        }

        [Route("Nashtech/Rookies/Task1")]
        public IActionResult Task1()
        {
            listMember();
            List<Person> maleList = list.Where(mb => mb.Gender == true).Select(m => m).ToList();
            return View(maleList);
        }

        [Route("Nashtech/Rookies/Task2")]
        public IActionResult Task2()
        {
            listMember();
            List<Person> ageList = list.OrderByDescending(old => old.Age).ThenBy(alpha => alpha).ToList();

            return View(ageList);
        }

        [Route("Nashtech/Rookies/Task3")]
        public IActionResult Task3()
        {
            listMember();
            return View();
        }

        [Route("Nashtech/Rookies/Task4")]
        public IActionResult Task4(string smallTask)
        {
            listMember();
            if (smallTask == "1")
            {
                return RedirectToAction("Task4_1","Rookies");
            }
            else if (smallTask == "2")
            {
                return RedirectToAction("Task4_2","Rookies");
            }
            else if (smallTask == "3")
            {
                return RedirectToAction("Task4_3","Rookies");
            }
            return View();
        }

        [Route("Nashtech/Rookies/Task4_1")]
        public IActionResult Task4_1(string smallTask)
        {
            listMember();
            //smallTask = "1";
            List<Person> theSame = list.Where(mb => mb.DateOfBirth.Year == 2000).Select(m => m).ToList();
            return View(theSame);
        }

        [Route("Nashtech/Rookies/Task4_2")]
        public IActionResult Task4_2(string smallTask)
        {
            listMember();
            //smallTask = "2";
            List<Person> theGreater = list.Where(mb => mb.DateOfBirth.Year < 2000).Select(m => m).ToList();
            return View(theGreater);
        }

        [Route("Nashtech/Rookies/Task4_3")]
        public IActionResult Task4_3(string smallTask)
        {
            listMember();
            //smallTask = "3";
            List<Person> theLess = list.Where(mb => mb.DateOfBirth.Year > 2000).Select(m => m).ToList();
            return View(theLess);
        }



        [Route("Nashtech/Rookies/Task5")]
        public IActionResult Task5()
        {
            listMember();
            var builder = new StringBuilder();
            builder.AppendLine("FirstName,LastName,Gender,DateOfBirth,Phone,BirthPlace,Age,IsGradated");
            foreach(var person in list){
                builder.AppendLine($"{person.FirstName},{person.LastName},{person.Gender},{person.DateOfBirth},{person.Phone},{person.BirthPlace},{person.Age},{person.IsGradated}");
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()),"text/csv","ListPerson.csv");

        }


        

    }

}