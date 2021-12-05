using DemoPatterns.FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.FactoryMethod
{
    public abstract class TransportFactory
    {
        public abstract ITransport CreateTransport();
    }
}
