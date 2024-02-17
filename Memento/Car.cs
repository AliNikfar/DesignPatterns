using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class CarState
    {
        public int Fuel { get; set; }
        public int Speed { get; set; }
    }


    public class Car
    {
        private int _fuel;
        private int _speed;

        public Car(CarState state)
        {
            _fuel = state.Fuel;
            _speed = state.Speed;
        }

        public Car()
        {
        }

        public void AddFuel( int value)
        {
            _fuel += value;
        }
        public void IncreaseSpeed()
        {
            _speed++;
        }
        public void DecreaseSpeed()
        {
            _speed--;
        }
        public void Kilometers()
        {
            _fuel -= 6;
        }
        public CarState GetState()
        {
            return new CarState()
            {
                Fuel = _fuel,
                Speed = _speed
            };
        }
    }
}
