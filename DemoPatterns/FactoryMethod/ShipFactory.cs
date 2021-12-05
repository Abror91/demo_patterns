using DemoPatterns.FactoryMethod.Models;

namespace DemoPatterns.FactoryMethod
{
    public class ShipFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
