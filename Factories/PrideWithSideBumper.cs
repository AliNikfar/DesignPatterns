
using Factories;

public class PrideWithSideBumper : ICar
{
    public PrideWithSideBumper( string bumperColor)
    {

    }
    public void End()
    {
        Console.WriteLine("Price with Side Bumper Ends");
    }

    public void Start()
    {
        Console.WriteLine("Price with Side Bumper Starts");
    }
}
