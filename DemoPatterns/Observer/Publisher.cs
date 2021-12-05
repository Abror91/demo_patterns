using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Observer
{
    public class Publisher
    {
        private List<IObserver> observers { get; set; }
        private string state { get; set; }
        public Publisher()
        {
            observers = new List<IObserver>();
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        private void Update()
        {
            foreach(var s in observers)
            {
                s.Update(this.state);
            }
        }

        public void UpdateState(string message)
        {
            this.state = message;
            Update();
        }
    }
}
