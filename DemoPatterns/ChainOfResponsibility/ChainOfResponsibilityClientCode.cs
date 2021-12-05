using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.ChainOfResponsibility
{
    public class ChainOfResponsibilityClientCode
    {
        public static void Test()
        {
            var helen = new HeadChef();
            var simon = new PurchasingManager();
            var julia = new GeneralManager();

            //set supervisors
            helen.SetSupervisor(simon);
            simon.SetSupervisor(julia);

            //create purchase requests
            var request1 = new PurchaseOrder(100, 5, 50, "purchase boards");
            var request2 = new PurchaseOrder(101, 10, 250, "purchase tables");

            helen.ProcessRequest(request1);
            helen.ProcessRequest(request2);

            Console.ReadLine();
        }
    }
}
