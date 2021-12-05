using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Decorator
{
    public class DecoratorCLientCode
    {
        public static void Test()
        {
            INotifier emailNotifier = new EmailNotifier();
            INotifier smsNotifier = new SmsNotifier(emailNotifier);
            INotifier facebookNotifier = new FacebookNotifier(smsNotifier);
            facebookNotifier.Notify("wazup");
        }
    }
}
