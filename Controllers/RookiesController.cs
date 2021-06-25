using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Threading.Tasks;

namespace Core_MVC.Controllers
{
    public class Rookies : Controller
    {
        public List<Person> listMembers = new List<Person>
        {
            new Person { FirstName = "Ngo", LastName = "Huy", Gender = true, DateOfBirth = new DateTime(1998, 06, 21), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 24, IsGradated = true , Email = "ngohuy98@gmail.com"},
            new Person { FirstName = "Tran", LastName = "Thuy", Gender = false, DateOfBirth = new DateTime(2001, 04, 11), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 25, IsGradated = false ,Email = "thuytran10@gmail.com"},
            new Person { FirstName = "Nguyen", LastName = "Phong", Gender = true, DateOfBirth = new DateTime(2001, 03, 11), Phone = 0329865444, BirthPlace = "Ha Tinh", Age = 27, IsGradated = false ,Email = "ngphong01@gmail.com"},
            new Person { FirstName = "Le", LastName = "Ha", Gender = false, DateOfBirth = new DateTime(2000, 03, 11), Phone = 0329865444, BirthPlace = "Ha Nam", Age = 20, IsGradated = false ,Email = "hale200@gmail.com"},
            new Person { FirstName = "Dao", LastName = "Tuan", Gender = true, DateOfBirth = new DateTime(1999, 03, 11), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 22, IsGradated = true ,Email = "daotuan1139@gmail.com"},
        };

        //
        //
        // Day-6
        //
        //

        [Route("Nashtech/Rookies/Index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(listMembers);
        }

        //[Route("Nashtech/Rookies/Create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("FirstName,LastName,Gender,DateOfBirth,Phone,BirthPlace,Age,IsGradated,Email")] Person member)
        {
            if (ModelState.IsValid)
            {

                listMembers.Add(member);

                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        
        public IActionResult Edit(string email)
        {
            return View(listMembers.Find(a => a.Email == email ));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("FirstName,LastName,Gender,DateOfBirth,Phone,BirthPlace,Age,IsGradated,Email")] Person member)
        {
            if (ModelState.IsValid)
            {

                listMembers.Add(member);

                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        public IActionResult Delete(string email)
        {

            return View(listMembers.Find(a => a.Email == email ));
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string email)
        {
            var member = listMembers.Find(i => i.Email == email);
            listMembers.Remove(member);
            //listMembers.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



        //
        //
        // Day-5
        //
        //


        [Route("Nashtech/Rookies/Task1")]
        public IActionResult Task1()
        {

            List<Person> maleList = listMembers.Where(mb => mb.Gender == true).Select(m => m).ToList();
            return View(maleList);
        }

        [Route("Nashtech/Rookies/Task2")]
        public IActionResult Task2()
        {
            List<Person> ageList = listMembers.OrderByDescending(old => old.Age).ThenBy(alpha => alpha).ToList();

            return View(ageList);
        }

        [Route("Nashtech/Rookies/Task3")]
        public IActionResult Task3()
        {
            return View(listMembers.ToList());
        }

        [Route("Nashtech/Rookies/Task4")]
        public IActionResult Task4(string smallTask)
        {
            if (smallTask == "1")
            {
                return RedirectToAction("Task4_1", "Rookies");
            }
            else if (smallTask == "2")
            {
                return RedirectToAction("Task4_2", "Rookies");
            }
            else if (smallTask == "3")
            {
                return RedirectToAction("Task4_3", "Rookies");
            }
            return View(listMembers.ToList());
        }

        [Route("Nashtech/Rookies/Task4_1")]
        public IActionResult Task4_1(string smallTask)
        {
            //smallTask = "1";
            List<Person> theSame = listMembers.Where(mb => mb.DateOfBirth.Year == 2000).Select(m => m).ToList();
            return View(theSame);
        }

        [Route("Nashtech/Rookies/Task4_2")]
        public IActionResult Task4_2(string smallTask)
        {
            //smallTask = "2";
            List<Person> theGreater = listMembers.Where(mb => mb.DateOfBirth.Year < 2000).Select(m => m).ToList();
            return View(theGreater);
        }

        [Route("Nashtech/Rookies/Task4_3")]
        public IActionResult Task4_3(string smallTask)
        {
            //smallTask = "3";
            List<Person> theLess = listMembers.Where(mb => mb.DateOfBirth.Year > 2000).Select(m => m).ToList();
            return View(theLess);
        }



        [Route("Nashtech/Rookies/Task5")]
        public IActionResult Task5()
        {

            var builder = new StringBuilder();
            builder.AppendLine("FirstName,LastName,Gender,DateOfBirth,Phone,BirthPlace,Age,IsGradated");
            foreach (var person in listMembers)
            {
                builder.AppendLine($"{person.FirstName},{person.LastName},{person.Gender},{person.DateOfBirth},{person.Phone},{person.BirthPlace},{person.Age},{person.IsGradated}");
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "ListPerson.csv");

        }

    }

}