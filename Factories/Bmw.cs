namespace Factories
{
    public class Bmw : ICar
    {
        public void End()
        {
            Console.WriteLine("BMW Ends");
        }

        public void Start()
        {
            Console.WriteLine("BMW Starts");
        }
    }

}
