
using Facade.ExternalServices;


/// Without Design Patterns 
var zoneFinder = new ZoneFinder();
var zone = zoneFinder.GetZone("65468484");
var tempratureService = new TempratureService();
var temprature = tempratureService.GetTemp(zone);
var tempConvertor = new TempConvertor();
var ZoneTemprature = tempConvertor.GetCelsius(temprature);
Console.WriteLine(ZoneTemprature);

/// With Facade  Design Pattern
var tempFacade = new TempFacade();
Console.WriteLine(tempFacade.GetTemp("54848343"));