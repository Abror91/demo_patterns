using DemoPatterns.FactoryMethod.Models;

namespace DemoPatterns.FactoryMethod
{
    public class TruckFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
