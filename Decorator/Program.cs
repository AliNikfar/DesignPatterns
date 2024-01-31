
//using Decorator DesignPattern
using Decorator;


//Short Description About Decorator:
//Add New Act to a Object  Without make Any Problem for The functiality of the current actions

LargeIceCreame LargeIceCreame1 = new LargeIceCreame();
Console.WriteLine(LargeIceCreame1.GetPrice() + " " + LargeIceCreame1.GetName());

LargeIceCreame LargeIceCreame = new LargeIceCreame();
var cho = new IceCreamWithChocolate(LargeIceCreame);
Console.WriteLine(cho.GetPrice() + " "+ cho.GetName());


MediumIceCreame mediumIceCreame1 = new MediumIceCreame();
Console.WriteLine(mediumIceCreame1.GetPrice() + " " + mediumIceCreame1.GetName());


MediumIceCreame mediumIceCreame = new MediumIceCreame();
var smar = new IceCreameWithSmartis(mediumIceCreame);
Console.WriteLine(smar.GetPrice() + " " + smar.GetName());

SmallIceCreame smallIceCreame1 = new SmallIceCreame();
Console.WriteLine(smallIceCreame1.GetPrice() + " " + smallIceCreame1.GetName());


SmallIceCreame smallIceCreame = new SmallIceCreame();
var cho1 = new IceCreamWithChocolate(smallIceCreame);
var smar1 = new IceCreameWithSmartis(cho1);
Console.WriteLine(smar1.GetPrice() + " " + smar1.GetName());

