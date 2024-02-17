// short Description About Mediator:
// when we have some of object and they need to have comunication to eachother
//using mediator  to being the connector between each objects.


// Normal Implement


using Mediator;

public class MehrabadTower : ITower
{
    public List<AirPlane1> AirPlaneList { get; set; } = new List<AirPlane1>();
    List<AirPlane1> ITower.AirPlaneList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public bool AllowChange()
    {
        {
            var result = false;
            foreach (var crnt in AirPlaneList)
            {
                if (crnt is AirBus1) 
                {
                    var temp = crnt as AirBus1;
                    //Calc Result
                }
                if (crnt is Foker1)
                {
                    var temp = crnt as Foker1;
                    //Calc Result
                }
                if (crnt is Topolov1)
                {
                    var temp = crnt as Topolov1;
                    //Calc Result
                }
            }
            return result;
        }
    }


    public void Register(AirPlane1 airPlane)
    {
        AirPlaneList.Add(airPlane);
    }

    public void Remove(AirPlane1 airPlane)
    {
        AirPlaneList.Remove(airPlane);
    }

}

