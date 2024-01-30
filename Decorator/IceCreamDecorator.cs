using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public  class IceCreamDecorator : IceCreame
    {
        private readonly IceCreame iceCreame;

        protected IceCreamDecorator( IceCreame iceCreame)
        {
            this.iceCreame = iceCreame;
        }

        public override string GetName()
        {
            return iceCreame.GetName();
        }

        public override int GetPrice()
        {
            return iceCreame.GetPrice();
        }
    }
}
