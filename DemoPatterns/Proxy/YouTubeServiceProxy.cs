using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Proxy
{
    public class YouTubeServiceProxy : IYouTubeService
    {
        private readonly IYouTubeService _service;
        private IEnumerable<object> _videosList { get; set; }
        private object _video { get; set; }
        private string _videoInfo { get; set; }
        private bool _reset { get; set; }
        public YouTubeServiceProxy(IYouTubeService service)
        {
            _service = service;
        }
        public object GetVideo(int id)
        {
            if (_video == null || _reset)
                _video = _service.GetVideo(id);
            return _video;
        }

        public string GetVideoInfo(int id)
        {
            if (_videoInfo == null || _reset)
                _videoInfo = _service.GetVideoInfo(id);
                    return _videoInfo;
        }

        public IEnumerable<object> GetVideos()
        {
            if (_videosList == null || _reset)
                _videosList = _service.GetVideos();
            return _videosList;
        }
    }
}
