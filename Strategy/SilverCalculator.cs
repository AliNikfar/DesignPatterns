using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SilverCalculator : CalcFinalPrice
    {
        public override int Calculate(int price)
        {
            return price-10;
        }
    }
}
