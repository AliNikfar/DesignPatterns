
namespace Strategy
{
    public class OrderStrategy
    {
        public OrderStrategy(int price , CalcFinalPrice calcFinalPrice)
        { 
            Price = price;
            CalcFinalPrice = calcFinalPrice;
        }
        public int Price { get; set; }
        public CalcFinalPrice CalcFinalPrice { get; set; }
        public int GetFinalPrice()
        {
            return CalcFinalPrice.Calculate(Price);
        }



    }
}
