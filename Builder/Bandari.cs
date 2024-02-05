
public class Bandari : SandwichIngridients
{
    public override void SetBread()
    {
        _sandwich._breadType = BreadType.Buget;
    }

    public override void SetCheez()
    {
        _sandwich._cheezType = CheezType.Motzarella;
    }

    public override void SetMeat()
    {
        _sandwich._meatType = MeatType.Susage;
    }

    public override void SetVegs()
    {
        _sandwich._vegs = new List<string>
        {
            "Onion"
        };
    }
}


