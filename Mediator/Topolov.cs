// short Description About Mediator:
// when we have some of object and they need to have comunication to eachother
//using mediator  to being the connector between each objects.


// Normal Implement


using Mediator;

public class Topolov : AirPlane
{
    public Topolov(string uniqName)
    {
        Name = $"Topolov {uniqName} ";
        AcceptableDistance = 800;
    }

    public override bool AllowChange()
    {
        var result = false;
        foreach (var crnt in CloseAirplaneList)
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


public class Topolov1 : AirPlane1
{
    public Topolov1(string uniqName, ITower tower) : base(tower)
    {
        Name = $"AirBus {uniqName} ";
        AcceptableDistance = 1000;
    }

}

