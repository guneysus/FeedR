using System;

namespace FeedR
{
    public class Entry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime Updated { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
    }
}
