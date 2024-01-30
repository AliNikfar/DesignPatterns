using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class IceCreameWithSmartis : IceCreamDecorator
    {
        public IceCreameWithSmartis(IceCreame iceCreame) : base(iceCreame)
        {
        }
        public override string GetName()
        {
            return $"{base.GetName()} with Smaritis";
        }
        public override int GetPrice()
        {
            return base.GetPrice() * 20 ;
        }
    }
}
