public class Sandwich
{
    //private readonly BreadType _breadType;
    //private readonly MeatType _meatType;
    //private readonly CheezType _cheezType;
    //private readonly List<string> _vegs;

    public BreadType _breadType;
    public MeatType _meatType;
    public CheezType _cheezType;
    public List<string> _vegs;



    //public Sandwich(BreadType breadType, MeatType meatType, CheezType cheezType, List<string> vegs)
    public Sandwich()
    {
        //this._breadType = breadType;
        //this._cheezType = cheezType;
        //this._meatType = meatType;
        //this._vegs = vegs;
    }
    public void GetSandwich()
    {
        Console.WriteLine("Sandwich breadType : " + _breadType);
        Console.WriteLine("Sandwich meatType: " + _meatType);
        Console.WriteLine("Sandwich cheezType: " + _cheezType);
        Console.WriteLine("Sandwich ingredients: " + String.Join(",", _vegs).ToString());


    }

}


