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
            var model = new PersonListViewModel();
            model.Persons = GetPersons();
            return View(model);
        }


        public IActionResult Details(int id = -1)
        {
            if(id == -1)
            {
                var model = new PersonListViewModel();
                model.Persons = GetPersons();
                return View(model);
            }
            else
            {
                var model = new PersonListViewModel();
                List<Person> p = new List<Person>();
                var data = persons.FirstOrDefault(d => d.Id == id);
                p.Add(data);
                model.Persons = p;
                return View(model);

            }
        }


        public static List<Person> persons = new List<Person>
        {
                new Person
                {
                    Id= 1,
                    Name = "John",
                    Surname = "Doe",
                    Age = 23,
                    ImageSource = "imagesource"
                },
                new Person
                {Id= 2,
                    Name = "Leyla",
                    Surname = "Aliyeva",
                    Age = 20,
                    ImageSource = "imagesource"
                },
                new Person
                {Id= 3,
                    Name = "Akif",
                    Surname = "Akifli",
                    Age = 25,
                    ImageSource = "imagesource"
                },
                new Person
                {Id= 4,
                    Name = "Arif",
                    Surname = "Arifli",
                    Age = 19,
                    ImageSource = "imagesource"
                },
                new Person
                {Id= 5,
                    Name = "John",
                    Surname = "Johnlu",
                    Age = 21,
                    ImageSource = "imagesource"
                },
                new Person
                {Id= 6,
                    Name = "Tural",
                    Surname = "Arifli",
                    Age = 23,
                    ImageSource = "imagesource"
                }
            };
        public List<Person> GetPersons()
        {
            return persons;
        }

    }
}
