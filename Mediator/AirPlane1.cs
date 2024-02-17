using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class AirPlane1 : IDisposable
    {
        private readonly ITower tower;
        public List<AirPlane1> CloseAirplaneList { get; set; } 


        public AirPlane1(ITower tower)
        {
            this.tower = tower;
            this.tower.Register(this);
        }
         
        public string Name { get; set; }
        public void ChangeElevation()
        {
            if (tower.AllowChange())
            { 

            }
        }


        public void Dispose()
        {
            tower.Remove(this);
        }

        public int AcceptableDistance { get; set; }
        public AirPlane1()
        {
            CloseAirplaneList = new List<AirPlane1>();
        }
    }
}
