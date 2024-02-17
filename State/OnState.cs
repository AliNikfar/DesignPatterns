// Short description About State:
//It help Us To change  a Object's Functionality according to the Object's state 

//normal implementation
public class OnState : IState
{
    public bool ChangeState()
    {
        Console.WriteLine("Turn Tv On");
        return  true;
    }
}

