// Short description About State:
//It help Us To change  a Object's Functionality according to the Object's state 

//normal implementation

public class Tv
{
    public bool IsOn { get; set; }
    public void OnOffBtnPshed()
    {
        if (IsOn)
        {
            Console.WriteLine("Turn Tv Off");
            IsOn = false;
        }
        else
        {
            Console.WriteLine("Turn Tv On");
            IsOn = true;
        }
    }
}

