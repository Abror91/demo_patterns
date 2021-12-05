using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Observer
{
    public class ObserverClientCode
    {
        public static void Test()
        {
            IObserver observer1 = new ConcreteObserver1();
            IObserver observer2 = new ConcreteObserver2();

            var publisher = new Publisher();
            publisher.Subscribe(observer1);
            publisher.Subscribe(observer2);

            publisher.UpdateState("wazup");

            Console.ReadLine();
        }

    }
}
