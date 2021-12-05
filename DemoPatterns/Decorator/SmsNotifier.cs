using System;

namespace DemoPatterns.Decorator
{
    public class SmsNotifier : BaseNotifier
    {
        public SmsNotifier(INotifier notifier) : base(notifier)
        {

        }

        public override void Notify(string message)
        {
            base.Notify(message);
            Console.WriteLine($"Notify via sms message: {message}");
        }
    }
}
