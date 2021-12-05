namespace DemoPatterns.ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver Supervisor { get; set; }
        public void SetSupervisor(Approver approver)
        {
            Supervisor = approver;
        }

        public abstract void ProcessRequest(PurchaseOrder order);
    }
}
