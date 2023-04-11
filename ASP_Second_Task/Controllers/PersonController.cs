using ASP_Second_Task.Entities;
using ASP_Second_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Second_Task.Controllers
{
    public class PersonController : Controller
    {

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new PersonListViewModel
            {
                Persons = new Person()
            };
        }
    }
}
