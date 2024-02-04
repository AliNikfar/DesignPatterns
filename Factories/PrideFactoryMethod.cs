
using Factories;

public class PrideFactoryMethod : ICarFactoryMethod
{
    public ICar CreateInstance()
    {
        return new Pride();
    }
}
