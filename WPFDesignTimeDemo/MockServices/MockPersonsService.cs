using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDesignTimeDemo.Models;
using WPFDesignTimeDemo.Services;

namespace WPFDesignTimeDemo.MockServices
{
    class MockPersonsService : IPersonsService
    {
        private readonly IList<Person> persons = new List<Person>
        {
            new Person { FirstName = "Marcin", LastName = "Sulecki", Age = 18, PhoneNumber = "5554434343"},
            new Person { FirstName = "Bartek", LastName = "Sulecki", Age = 18, PhoneNumber = "5554434343"},
        };

        public IList<Person> Get()
        {
            return persons;
        }
    }
}
