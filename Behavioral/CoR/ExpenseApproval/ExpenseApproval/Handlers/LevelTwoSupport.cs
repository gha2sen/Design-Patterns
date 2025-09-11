using ExpenseApproval.Constants;

namespace ExpenseApproval.Handlers
{
    internal class LevelTwoSupport : ITSupportHandler
    {
        public override void HandleSupportRequest(RequestType request)
        {
            if (CanHandleSupportRequest(request))
            {
                Console.WriteLine("Level two support handled request:{0}", request.ToString());
            }
            else
            {
                _nextSupportLevel.HandleSupportRequest(request);
            }
        }

        protected override bool CanHandleSupportRequest(RequestType request) => request == RequestType.ConfigurationIssue;
    }
}
