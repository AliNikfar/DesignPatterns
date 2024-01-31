public abstract class PizzaCooker
{
    public void Cook()
    {
        PrepareBread();
        PrepareIngredients();
        ComposeMaterial();
        StartCooking();
        SendToCustomer();
    }
    public abstract void PrepareBread();
    public abstract void PrepareIngredients();
    public void ComposeMaterial()
    {
        //  Add Materials to the Pizza
    }
    public void StartCooking()
    {
        // Start Cooking
    }
    public void SendToCustomer()
    {
        //send to the customer
    }
}
