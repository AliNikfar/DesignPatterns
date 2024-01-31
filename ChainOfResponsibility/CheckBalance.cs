


public class CheckBalance : TransferMoney
    {
        public CheckBalance(TransferMoney succesor) : base(succesor)
        {
        }

        public override ResponseContext Execute(RequestContext requestContext)
        {
            if (requestContext.From.AccountValue >= requestContext.Value  )
            {
                return _Succesor.Execute(requestContext);
            }
            return new ResponseContext()
            {
                Message = "sender has not enogh balance"
            };


        }

    }
