

public class TransferFinal : TransferMoney
{
    public TransferFinal(TransferMoney succesor) : base(succesor)
    {
    }

    public override ResponseContext Execute(RequestContext requestContext)
    {
        requestContext.From.AccountValue -= requestContext.Value;
        requestContext.To.AccountValue += requestContext.Value;
        return new ResponseContext()
        {
            Message = "Transfer Completed"
        };
    }
}
