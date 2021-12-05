using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Proxy
{
    public class YouTubeService : IYouTubeService
    {
        public object GetVideo(int id)
        {
            return new object();
        }

        public string GetVideoInfo(int id)
        {
            return "video info";
        }

        public IEnumerable<object> GetVideos()
        {
            return new List<Object>();
        }
    }
}
