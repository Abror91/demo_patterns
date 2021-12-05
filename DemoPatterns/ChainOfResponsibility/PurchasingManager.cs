using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.ChainOfResponsibility
{
    public class PurchasingManager: Approver
    {
        public override void ProcessRequest(PurchaseOrder order)
        {
            if(order.TotalCost < 2500)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, order.PurchaseNumber);
            }
            else
            {
                if(Supervisor != null)
                {
                    Supervisor.ProcessRequest(order);
                }
            }
        }
    }
}
