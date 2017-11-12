using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDesignTimeDemo.Models;

namespace WPFDesignTimeDemo.ViewModels
{
    class CustomersViewModel
    {
        public IList<Customer> Customers { get; set; }

        public CustomersViewModel()
        {
            Customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Marcin", LastName = "Sulecki" },
                new Customer { Id = 2, FirstName = "Bartek", LastName = "Sulecki" },
            };
        }
    }
}
