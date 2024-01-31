

public abstract class TransferMoney
{
    protected readonly TransferMoney _Succesor;

    protected TransferMoney(TransferMoney succesor)
    {
        _Succesor = succesor;
    }

    public abstract ResponseContext Execute(RequestContext requestContext);

}