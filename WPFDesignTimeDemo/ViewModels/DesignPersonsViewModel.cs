using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDesignTimeDemo.MockServices;

namespace WPFDesignTimeDemo.ViewModels
{
    class DesignPersonsViewModel : PersonsViewModel
    {
        public DesignPersonsViewModel()
            : base(new MockPersonsService())
        {

        }
    }
}
