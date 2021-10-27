using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using modelss;

namespace DataAccessLayer.Repositories
{

    public class RSSReader
    {

        public List<Avsnitt> RssRead(string url)
        {


            List<Avsnitt> avsnitt = new List<Avsnitt>();
            XDocument rssfeedxml = new XDocument();

            //XNamespace namespaceName = "http://www.w3.org/2005/Atom";


            rssfeedxml = XDocument.Load(url);

                // StringBuilder rssContent = new StringBuilder();

                avsnitt = (from descendant in rssfeedxml.Descendants("item")

                               //Response.Write(list);  
                           select new Avsnitt
                           {
                               NewsTitel = descendant.Element("title").Value,
                               NewsDescription = descendant.Element("description").Value,
                               NewsLink = descendant.Element("link").Value,
                               //date = descendant.Element("pubDate").Value,
                               //auth = descendant.Element("author").Value

                           }).ToList();
         return avsnitt;

        }
    }
}

            //    string subject = "";
            //    string summary = "";
            //    var x = "";
            //    var y = "";
            //    var count = 0;
            //    //var list = new List<Tuple<string, string>>();
            //     var podcast = new List<Podcast>();
            //    try
            //    {



//        XmlReader reader = XmlReader.Create(url);
//        SyndicationFeed feed = SyndicationFeed.Load(reader);
//        reader.Close();


//        feed = (from x in feed.Descendants("item")
//                   select new Episode
//                   {
//                       Name = x.Element("title").Value,
//                       Description = x.Element("description").Value,
//                       SoundFile = x.Descendants("link").Any() ? x.Element("link").Value : x.Descendants("enclosure").Any() ? x.Element("enclosure").Attribute("url").Value : "None"
//                   }).ToList();

//    //foreach (SyndicationItem item in feed.Items)
//    //{


//    //    subject = item.Title.Text;
//    //    summary = item.Summary.Text;
//    //    x += count + " " + subject + " ";
//    //    podcast.Add(new Tuple<string, string>("Avsnitt " + count + " " + subject, summary));

//    //}

//}
//    catch (Exception message)
//    {
//        Console.WriteLine(message);
//    }
//    //Datahandler.SavePodFeed(list);
//    return podcast;
//}
//}

//public class RSSreader
//{
//    public static List<Tuple<string, string>> rssRead(string url)
//    {
//        string subject = "";
//        string summary = "";
//        var x = "";
//        var y = "";
//        var count = 0;
//        var list = new List<Tuple<string, string>>();
//        try
//        {


//            //string urlX = "http://feeds.soundcloud.com/users/soundcloud:users:298230954/sounds.rss";
//            XmlReader reader = XmlReader.Create(url);
//            SyndicationFeed feed = SyndicationFeed.Load(reader);
//            reader.Close();

//            foreach (SyndicationItem item in feed.Items)
//            {
//                count++;
//                subject = item.Title.Text;
//                summary = item.Summary.Text;
//                x += count + " " + subject + " ";
//                list.Add(new Tuple<string, string>("Avsnitt " + count + " " + subject, summary));

//            }

//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex);
//        }

//        return list;

//    }
//}


