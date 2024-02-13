namespace FlyWeight
{
    public abstract class Alphabet
    {
        protected string character;
        public void Print(int x, int y, string color)
        {
            Console.WriteLine($"x: {x} , y: {y} , color: {color} {character}");
        }
    }
}

