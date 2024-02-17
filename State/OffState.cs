// Short description About State:
//It help Us To change  a Object's Functionality according to the Object's state 

//normal implementation
public class OffState : IState
{
    public bool ChangeState()
    {
        Console.WriteLine("Turn Tv Off");
        return false;
    }
}

