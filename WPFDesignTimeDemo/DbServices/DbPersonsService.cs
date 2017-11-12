using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDesignTimeDemo.Models;
using WPFDesignTimeDemo.Services;

namespace WPFDesignTimeDemo.DbServices
{
    class DbPersonsService : IPersonsService
    {
        private readonly IList<Person> persons = new List<Person>
        {
            new Person { FirstName = "John", LastName = "Smith", Age = 18, PhoneNumber = "5554434343"},
            new Person { FirstName = "Ann", LastName = "Smith", Age = 18, PhoneNumber = "5554434343"},
            new Person { FirstName = "Bart", LastName = "Spider", Age = 18, PhoneNumber = "5554434343"},
        };

        public IList<Person> Get()
        {
            return persons;
        }
    }
}
