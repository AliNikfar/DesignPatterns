using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class LargeIceCreame : IceCreame
    {
        public override string GetName()
        {
            return "Large IceCreame";
        }

        public override int GetPrice()
        {
            return 200;
        }
    }
}
