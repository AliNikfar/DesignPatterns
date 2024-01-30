using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class IceCreamWithChocolate : IceCreamDecorator
    {
        public  IceCreamWithChocolate(IceCreame iceCreame) : base(iceCreame)
        {
        }
        public override string GetName()
        {
            return $"{base.GetName()} with Chocolate ";
        }
        public override int GetPrice()
        {
            return base.GetPrice() * 30;
        }
    }
}
