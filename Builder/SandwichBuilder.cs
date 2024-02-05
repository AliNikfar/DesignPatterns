public class SandwichBuilder
{
    private readonly SandwichIngridients _sandwichIngridients;
    public SandwichBuilder(SandwichIngridients sandwichIngridients)
    {
        this._sandwichIngridients = sandwichIngridients;
        _sandwichIngridients.SetBread();
        _sandwichIngridients.SetMeat();
        _sandwichIngridients.SetCheez();
        _sandwichIngridients.SetVegs();
    }
    public Sandwich GetSandwich()
    {
        return _sandwichIngridients._sandwich;
    }

}


