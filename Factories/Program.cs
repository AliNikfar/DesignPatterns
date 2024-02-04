
using Factories;
// Simple Factory
CarSimpleFactory carFactory = new CarSimpleFactory();

ICar pride = carFactory.GetCar("pride");
ICar bmw = carFactory.GetCar("BMW");
pride.Start();
bmw.Start();
pride.End();
bmw.End();
Console.ReadKey();

// Factory Method
var CarFactory = new PrideFactoryMethod();
ICar car = CarFactory.CreateInstance();
car.Start();    
car.End();