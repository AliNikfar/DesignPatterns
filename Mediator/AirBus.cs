// short Description About Mediator:
// when we have some of object and they need to have comunication to eachother
//using mediator  to being the connector between each objects.


// Normal Implement


using Mediator;

public class AirBus : AirPlane
{
    public AirBus( string uniqName)
    {
        Name = $"AirBus {uniqName} " ;
        AcceptableDistance = 1000;
    }

    public override bool AllowChange()
    {
        var result = false;
        foreach( var crnt in CloseAirplaneList)
        {
            if (crnt is AirBus)
            {
                var temp = crnt as AirBus;
                //Calc Result
            }
            if (crnt is Foker)
            {
                var temp = crnt as AirBus;
                //Calc Result
            }
            if (crnt is Topolov)
            {
                var temp = crnt as AirBus;
                //Calc Result
            }
        }
        return result;
    }
}

public class AirBus1 : AirPlane1
{
    public AirBus1(string uniqName,ITower tower) : base(tower)
    {
        Name = $"AirBus {uniqName} ";
        AcceptableDistance = 1000;
    }
}

