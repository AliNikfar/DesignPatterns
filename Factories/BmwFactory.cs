
using Factories;

public class BmwFactory : IAbstractFactory
{
    public ICar Cross()
    {
        return new  BmwX3();
    }

    public ICar Luxtury()
    {
        return new Bmw7Serie();
    }

    public ICar Sedan()
    {
        return new Bmw();
    }
}

