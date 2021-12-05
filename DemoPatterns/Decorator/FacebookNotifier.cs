using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Decorator
{
    public class FacebookNotifier : BaseNotifier
    {
        public FacebookNotifier(INotifier notifier) : base(notifier)
        {

        }

        public override void Notify(string message)
        {
            base.Notify(message);
            Console.WriteLine($"Notify via facebook message: {message}");
        }
    }
}
