// short Description About Mediator:
// when we have some of object and they need to have comunication to eachother
//using mediator  to being the connector between each objects.


// Normal Implement
AirBus airbus1 = new AirBus("001");
AirBus airbus2 = new AirBus("002");
airbus1.CloseAirplaneList.Add(airbus2);
airbus2.CloseAirplaneList.Add(airbus1);

Foker foker1 = new Foker("001");
airbus1.CloseAirplaneList.Add(foker1);
airbus2.CloseAirplaneList.Add(foker1);
foker1.CloseAirplaneList.Add(airbus1);
foker1.CloseAirplaneList.Add(airbus2);

Topolov topolov1 = new Topolov("001");
airbus1.CloseAirplaneList.Add(topolov1);
airbus2.CloseAirplaneList.Add(topolov1); 
foker1.CloseAirplaneList.Add(topolov1);
topolov1.CloseAirplaneList.Add(airbus1);
topolov1.CloseAirplaneList.Add(airbus2);
topolov1.CloseAirplaneList.Add(foker1);


// using Mediator

ITower tehran = new MehrabadTower();
AirBus1 airBus = new AirBus1("001", tehran);
AirBus1 airBus2 = new AirBus1("002", tehran);
Foker1 Foker1 = new Foker1("001", tehran);
Topolov1 topolov11 = new Topolov1("001", tehran);
tehran.Remove(airBus);


