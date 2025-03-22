using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDB
{
    public class Employee : EntityBase
    {
        public string EmpName { get; set; }
        public string Department { get; set; }
        public bool Active { get; set; }
    }
}
