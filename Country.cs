using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDB
{
    public class Country : EntityBase
    {
        public string CountryName { get; set; }
        public string Capital { get; set; }  
    }
}
