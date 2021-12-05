using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Proxy
{
    public class ProxyClientCode
    {
        public static void Test()
        {
            IYouTubeService service = new YouTubeService();
            IYouTubeService proxyService = new YouTubeServiceProxy(service);
            var manager = new YouTubeManager(proxyService);
            manager.DisplayVideos();
            manager.DisplayVideos();
        }
    }
}
