
using Factories;

public class BmwFactoryMethod : ICarFactoryMethod
{
    public ICar CreateInstance()
    {
        return new Bmw();
    }
}