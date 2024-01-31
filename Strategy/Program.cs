using Strategy;

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


