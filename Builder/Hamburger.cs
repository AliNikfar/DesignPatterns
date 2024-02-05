
public class Hamburger : SandwichIngridients
{
    public override void SetBread()
    {
        _sandwich._breadType = BreadType.Hamburger;
    }

    public override void SetCheez()
    {
        _sandwich._cheezType = CheezType.Goda;
    }

    public override void SetMeat()
    {
        _sandwich._meatType = MeatType.Beef;
    }

    public override void SetVegs()
    {
        _sandwich._vegs = new List<string>
        {
            "Onion",
            "Lettus"
        };
    }
}


