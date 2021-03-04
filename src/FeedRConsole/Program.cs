using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var feedUrl = "http://www.hellointernet.fm/podcast?format=rss";
            var reader = FeedR.FeedR.New("db.sqlite");

            reader.AddFeed(feedUrl);
            reader.UpdateFeeds();
            var feed = reader.GetFeed(feedUrl);
            (string feedTitle, DateTime lastChanged, DateTime updated) = (feed.Title, feed.LastChanged, feed.Updated);


            var entries = reader.GetEntries();


        }
    }
}
