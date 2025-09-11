
namespace ExpenseApproval.Handlers
{
    internal class LevelOneSupport : ITSupportHandler
    {
        public override void HandleSupportRequest(RequestType request)
        {
            if (CanHandleSupportRequest(request))
            {
                Console.WriteLine("Level one support handled request:{0}", request.ToString());
            }
            else 
            {  
                _nextSupportLevel.HandleSupportRequest(request);
            }
        }

        protected override bool CanHandleSupportRequest(RequestType request) => request == RequestType.PasswordReset;
    }
}
