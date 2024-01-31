

public class CheckPassword : TransferMoney
{
    public CheckPassword(TransferMoney succesor) : base(succesor)
    {
    }

    public override ResponseContext Execute(RequestContext requestContext)
    {
        if (requestContext.From.Password == requestContext.Password)
        {
            return _Succesor.Execute(requestContext);
        }
        return new ResponseContext()
        {
            Message = "Incorrect Password"
        };
    }
}
