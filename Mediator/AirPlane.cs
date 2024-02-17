// short Description About Mediator:
// when we have some of object and they need to have comunication to eachother
//using mediator  to being the connector between each objects.


// Normal Implement


public abstract class AirPlane 
{

    public List<AirPlane> CloseAirplaneList { get; set; } 

    public string Name { get; set; }
    public void ChangeElevation()
    {
        if (AllowChange())
        {

        }
    }
    public abstract bool AllowChange();
    public int AcceptableDistance { get; set; }
    public AirPlane()
    {
        CloseAirplaneList = new List<AirPlane>();
    }
}

