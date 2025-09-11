
namespace ExpenseApproval.Handlers
{
    public class NullHandler : ITSupportHandler
    {
        public override void HandleSupportRequest(RequestType request)
        {
            Console.WriteLine("Cant handler request: {0}", request.ToString());
        }

        protected override bool CanHandleSupportRequest(RequestType request)
        {
            return false;
        }
    }
}
