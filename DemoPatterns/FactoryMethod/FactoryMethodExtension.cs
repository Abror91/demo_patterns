using DemoPatterns.FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.FactoryMethod
{
    public static class FactoryMethodExtension
    {
        public static ITransport CreateTransport(TransportType type)
        {
            TransportFactory factory;
            switch (type)
            {
                case TransportType.Truck:
                    factory = new TruckFactory();
                    break;
                case TransportType.Ship:
                    factory = new ShipFactory();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }

            return factory.CreateTransport();
        }
    }
}
