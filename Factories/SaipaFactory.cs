
using Factories;

public class SaipaFactory : IAbstractFactory
{
    public ICar Cross()
    {
        return new PrideCross();
    }

    public ICar Luxtury()
    {
        return new PrideWithSideBumper("Black");
    }

    public ICar Sedan()
    {
        return new Pride();
    }
}

