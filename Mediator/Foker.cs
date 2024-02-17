// short Description About Mediator:
// when we have some of object and they need to have comunication to eachother
//using mediator  to being the connector between each objects.


// Normal Implement


using Mediator;

public class Foker : AirPlane
{
    public Foker(string uniqName)
    {
        Name = $"Foker {uniqName} ";
        AcceptableDistance = 500;
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

public class Foker1 : AirPlane1
{
    public Foker1(string uniqName, ITower tower) : base(tower)
    {
        Name = $"AirBus {uniqName} ";
        AcceptableDistance = 1000;
    }

}


