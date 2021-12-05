using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton _instance { get; set; }
        private static object padlock = new object();
        private Singleton() { }
        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                lock (padlock)
                {
                    if (_instance == null)
                        _instance = new Singleton();
                }
            }
            return _instance;
        }
    }
}
