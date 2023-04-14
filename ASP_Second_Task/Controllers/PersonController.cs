using ASP_Second_Task.Entities;
using ASP_Second_Task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Second_Task.Controllers
{
    public class PersonController : Controller
    {


        [HttpGet]
        public IActionResult Add()
        {
            var vm = new PersonViewModel()
            {
                Person = new Person(),
            };
            return View(vm);
        }


        [HttpPost]

        public RedirectResult Add(PersonViewModel viewModel)
        {
            HomeController.persons.Add(viewModel.Person);
            return Redirect("/home/index");
        }


    }
}
