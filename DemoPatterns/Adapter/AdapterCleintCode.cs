using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Adapter
{
    public class AdapterCleintCode
    {
        public static void Test()
        {
            DataService service = new DataService();
            IDataService adapterService = new DataServiceAdapter(service);
            Displayer displayer = new Displayer(adapterService);
        }
    }
}
