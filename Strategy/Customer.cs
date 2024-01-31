using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Customer
    {
        public string  FirstName{ get; set; }
        public string LastName{ get; set; }
        public CustomerType  Type { get; set; }
    }
}
