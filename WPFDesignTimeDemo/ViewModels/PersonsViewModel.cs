using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDesignTimeDemo.DbServices;
using WPFDesignTimeDemo.Models;
using WPFDesignTimeDemo.Services;

namespace WPFDesignTimeDemo.ViewModels
{
    class PersonsViewModel
    {

        private readonly IPersonsService personsService;

        public IList<Person> Persons { get; set; }

        public Person SelectedPerson { get; set; }


        public PersonsViewModel()
            : this(new DbPersonsService())
        {
            
        }

        public PersonsViewModel(IPersonsService personsService)
        {
            this.personsService = personsService;

            Load();
        }

        private void Load()
        {
            Persons = personsService.Get();

            SelectedPerson = Persons.FirstOrDefault();
        }
    }
}
