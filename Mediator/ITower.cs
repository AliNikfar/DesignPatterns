// short Description About Mediator:
// when we have some of object and they need to have comunication to eachother
//using mediator  to being the connector between each objects.

using Mediator;

public interface ITower
{
    List<AirPlane1> AirPlaneList { get; set; }
    void Register(AirPlane1 airPlane);
    void Remove(AirPlane1 airPlane);
    bool AllowChange();
}

