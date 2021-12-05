using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Observer
{
    public interface IObserver
    {
        void Update(string message);
    }
}
