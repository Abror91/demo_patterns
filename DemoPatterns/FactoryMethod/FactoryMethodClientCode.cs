using DemoPatterns.FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.FactoryMethod
{
    public class FactoryMethodClientCode
    {
        public static void Test()
        {
            ITransport truck = FactoryMethodExtension.CreateTransport(TransportType.Truck);
            ITransport ship = FactoryMethodExtension.CreateTransport(TransportType.Ship);

            truck.Deliver();
            ship.Deliver();
        }
    }
}
