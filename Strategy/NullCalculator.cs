using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NullCalculator : CalcFinalPrice
    {
        //implement "Null Object" Pattern For  the Customers that have no  declared type
        public override int Calculate(int price)
        {
            return price;
        }
    }
}
