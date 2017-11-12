using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDesignTimeDemo.Models;

namespace WPFDesignTimeDemo.Services
{
    interface IPersonsService
    {
        IList<Person> Get();
    }
}
