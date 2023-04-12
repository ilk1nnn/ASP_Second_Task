using ASP_Second_Task.Entities;
using System.Collections.Generic;

namespace ASP_Second_Task.Models
{
    public class PersonListViewModel
    {
        public List<Person> Persons = new List<Person>()
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
					Name = "John",
					Surname = "Johnlu",
					Age = 21,
					ImageSource = "imagesource"
				}
		};
        public Person Person { get; set; }

    }
}
