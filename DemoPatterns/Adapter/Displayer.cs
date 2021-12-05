namespace DemoPatterns.Adapter
{
    public class Displayer
    {
        private readonly IDataService _service;
        public Displayer(IDataService service)
        {
            _service = service;
        }
        public void Display(string data)
        {
            //draw charts from recieved data
            _service.GetData();
        }
    }
}
