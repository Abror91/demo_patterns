using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.ChainOfResponsibility
{
    public class GeneralManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder order)
        {
            if (order.TotalCost < 10000)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, order.PurchaseNumber);
            }
            else
            {
                Console.WriteLine("Call meeting!");
            }
        }
    }
}
