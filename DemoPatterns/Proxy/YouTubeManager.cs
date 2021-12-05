using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Proxy
{
    public class YouTubeManager
    {
        private readonly IYouTubeService _service;
        public YouTubeManager(IYouTubeService service)
        {
            _service = service;
        }

        public IEnumerable<object> DisplayVideos()
        {
            return _service.GetVideos();
        }
    }
}
