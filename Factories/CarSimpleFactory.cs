namespace Factories
{
    public class  CarSimpleFactory{
        public ICar GetCar(string CarName)
        {
            ICar car = null;
            switch (CarName)
            {
                case "Pride":
                    car = new Pride();
                    return car;
                    break;
                case "BMW":
                    car = new Bmw();
                    return car;
                    break;
            }
            return car;
        }
    }


     

}
