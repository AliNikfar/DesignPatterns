using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MediumIceCreame : IceCreame
    {
        public override string GetName()
        {
            return "Medium IceCreame";
        }

        public override int GetPrice()
        {
            return 150;
        }
    }
}
