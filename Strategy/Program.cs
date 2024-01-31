using Strategy;

//Short Description About Decorator:
//using Multi Conditions for a Object Without using "If" or "Switch" and make easy to defenitioning new type for conditions 

// Normal implement0
Customer customer = new Customer();
customer.FirstName = "ali";
customer.LastName = "Nikfar";
customer.Type = CustomerType.Silver;
var OrderNormal = new OrderNormal(1000, customer);
Console.WriteLine(OrderNormal.GetFinalPrice());


/// with Strategy
OrderStrategy Order = new OrderStrategy(1000,new BronzeCalculator());
Console.WriteLine(Order.GetFinalPrice().ToString());


