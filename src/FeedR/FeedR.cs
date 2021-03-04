using System;
using System.Collections.Generic;

namespace FeedR
{
    public class FeedR
    {
        public FeedR(string path)
        {

        }

        protected FeedR ()
        {

        }

        public static FeedR New(string path)
        {
            var feedr = new FeedR();
            return feedr;
        }

        public void UpdateFeeds()
        {
            throw new NotImplementedException();
        }

        public Feed GetFeed(string feedUrl)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entry> GetEntries()
        {
            throw new NotImplementedException();
        }

        public void AddFeed(string feedUrl)
        {
            throw new NotImplementedException();
        }
    }
}
