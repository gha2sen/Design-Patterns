

namespace ExpenseApproval.Interface
{
    public abstract class ITSupportHandler
    {
        protected ITSupportHandler _nextSupportLevel;


        public abstract void HandleSupportRequest(RequestType request);

        protected abstract bool CanHandleSupportRequest(RequestType request);

        public void SetNextSupportLevel(ITSupportHandler supportLevel) => _nextSupportLevel = supportLevel;
    }
}
