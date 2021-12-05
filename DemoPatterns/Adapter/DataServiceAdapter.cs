namespace DemoPatterns.Adapter
{
    public class DataServiceAdapter : IDataService
    {
        private readonly DataService _service;
        public DataServiceAdapter(DataService service)
        {
            _service = service;
        }
        public string GetData()
        {
            //conver xml data to json and return
            return _service.GetXmlData();
        }
    }
}
