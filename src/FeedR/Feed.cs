using System;

namespace FeedR
{
    public class Feed
    {
        public string Url { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public DateTime LastChanged { get; set; }
        public DateTime Updated { get; set; }
    }
}
