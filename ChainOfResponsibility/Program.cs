

//Short Description About Chain:

//Creating single Chains of same type and using them as chains of a workflow
// and make no problem on workflow with adding any single Chain to worflow
// or Change  priority of chains.



Customer from = new Customer()
{
    AccountValue = 1000,
    IsActive = true,
    MaxValuePerDay = 100,
    Password = "1234"

};
Customer to = new Customer()
{
    AccountValue = 10000,
    IsActive = true,
    MaxValuePerDay = 2000,
    Password = "1234"

};
TransferMoney Workflow1 = new CheckPassword(new CheckBalance(new TransferFinal(null)));
TransferMoney Workflow2 = new CheckPassword(new CheckBalance(new IsUserActive(new TransferFinal(null))));
TransferMoney Workflow3 = new CheckPassword(new CheckBalance(new TransferFinal(null)));


var result =  Workflow1.Execute(new RequestContext()
{
    From = from,
    To = to,
    Password = "1234",
    Value = 150
});
Console.WriteLine(result.Message);


var result2 = Workflow2.Execute(new RequestContext()
{
    From = from,
    To = to,
    Password = "1234",
    Value = 15000
});
Console.WriteLine(result2.Message);