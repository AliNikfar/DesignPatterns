using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SmallIceCreame : IceCreame
    {
        public override string GetName()
        {
            return "Small IceCreame";
        }

        public override int GetPrice()
        {
            return 100;
        }
    }
}
