using ASP_Second_Task.Entities;
using ASP_Second_Task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Second_Task.Controllers
{
    public class PersonController : Controller
    {


        private HomeController _controller { get; set; }

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new PersonListViewModel
            {
                Person = new Person()
            };
            return View(vm);
        }


        [HttpPost]

        public RedirectResult Add(PersonListViewModel viewModel)
        {
			viewModel.Persons.Add(viewModel.Person);
            return Redirect("/home/index");
        }


    }
}
