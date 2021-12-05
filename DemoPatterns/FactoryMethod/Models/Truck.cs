using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.FactoryMethod.Models
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("deliver by truck");
        }
    }
}
