using Strategy;

public class OrderNormal
{
    public OrderNormal(int price , Customer customer)
    {
        Price = price;
        Customer = customer;

    }

    public int Price { get; set; }
    public Customer Customer { get; set; }
    private CalcFinalPrice CalcFinalPrice { get; set; }
    public int GetFinalPrice()
    {
        switch (Customer.Type)
        {
            case CustomerType.Gold:
                return new GoldCalculator().Calculate(Price);
            case CustomerType.Silver:
                return new SilverCalculator().Calculate(Price);
            case CustomerType.Bronze:
                return new BronzeCalculator().Calculate(Price);
            default:
                return new NullCalculator().Calculate(Price);
        }
    }


}