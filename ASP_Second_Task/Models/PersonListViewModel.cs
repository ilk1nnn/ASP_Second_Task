using ASP_Second_Task.Entities;
using System.Collections.Generic;

namespace ASP_Second_Task.Models
{
	public class PersonListViewModel
	{
		public IEnumerable<Person> Persons { get; set; }
	}
}
