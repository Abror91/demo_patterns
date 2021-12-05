using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.FactoryMethod.Models
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("deliver by ship");
        }
    }
}
