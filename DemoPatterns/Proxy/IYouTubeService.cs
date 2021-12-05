using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Proxy
{
    public interface IYouTubeService
    {
        IEnumerable<object> GetVideos();
        object GetVideo(int id);
        string GetVideoInfo(int id);
    }
}
