public class IsUserActive : TransferMoney
    {
        public IsUserActive(TransferMoney succesor) : base(succesor)
        {
        }

        public override ResponseContext Execute(RequestContext requestContext)
        {
            if (requestContext.From.IsActive)
                return _Succesor.Execute(requestContext);

            return new ResponseContext()
            {
                Message = "Sender is not Active"
            };
        }
    }