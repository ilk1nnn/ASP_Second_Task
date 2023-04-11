using ASP_Second_Task.Entities;
using ASP_Second_Task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Second_Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            dynamic model = new PersonListViewModel();
            model.Persons = GetPersons();
            return View(model);
        }


        public List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>
            {
                new Person
                {
                    Name = "John",
                    Surname = "Doe",
                    Age = 23,
                    ImageSource = "imagesource"
                },
                new Person
                {
                    Name = "Leyla",
                    Surname = "Aliyeva",
                    Age = 20,
                    ImageSource = "imagesource"
                },
                new Person
                {
                    Name = "Akif",
                    Surname = "Akifli",
                    Age = 25,
                    ImageSource = "imagesource"
                }, 
                new Person
                {
                    Name = "Arif",
                    Surname = "Arifli",
                    Age = 19,
                    ImageSource = "imagesource"
                },
                new Person
                {
                    Name = "Arif",
                    Surname = "Arifli",
                    Age = 19,
                    ImageSource = "imagesource"
                },
                new Person
                {
                    Name = "Arif",
                    Surname = "Arifli",
                    Age = 19,
                    ImageSource = "imagesource"
                }
            };
            return persons;
        }

    }
}
