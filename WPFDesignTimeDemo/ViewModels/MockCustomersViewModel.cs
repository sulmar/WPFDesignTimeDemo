using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDesignTimeDemo.Models;

namespace WPFDesignTimeDemo.ViewModels
{
    class MockCustomersViewModel
    {
        public IList<Customer> Customers { get; set; }

        public MockCustomersViewModel()
        {
            Customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "John", LastName = "Smith" },
                new Customer { Id = 2, FirstName = "Ann", LastName = "Smitch " },
                new Customer { Id = 3, FirstName = "Bart", LastName = "Spider" },
            };
        }
    }
}
