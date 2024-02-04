
using Factories;

SimpleFactory();
FactoryMethod();
AbstractFactory();


 static void SimpleFactory()
{
    CarSimpleFactory carFactory = new CarSimpleFactory();
    ICar pride = carFactory.GetCar("Pride");
    ICar bmw = carFactory.GetCar("BMW");
    pride.Start();
    bmw.Start();
    pride.End();
    bmw.End();
    Console.ReadKey();
}

 static void FactoryMethod()
{
    var CarFactory = new PrideFactoryMethod();
    ICar car = CarFactory.CreateInstance();
    car.Start();
    car.End();
    Console.ReadKey();
}
static void AbstractFactory()
{
    var AbstractBMW  = new BmwFactory();
    ICar bmw = AbstractBMW.Luxtury();
    bmw.Start();
    bmw.End();

    var AbstractPride = new SaipaFactory();
    ICar pride = AbstractPride.Luxtury();
    pride.Start();
    pride.End();
    Console.ReadKey();


}


