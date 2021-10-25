using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace DataAccessLayer.Repositories
//{
//    class RSSReader
//    {
//        public static List<Tuple<string, string>> rssRead(string url)
//        {
//            string subject = "";
//            string summary = "";
//            var x = "";
//            var y = "";
//            var count = 0;
//            var list = new List<Tuple<string, string>>();
//            try
//            {



//                XmlReader reader = XmlReader.Create(url);
//                SyndicationFeed feed = SyndicationFeed.Load(reader);
//                reader.Close();

//                foreach (SyndicationItem item in feed.Items)
//                {
//                    count++;
//                    subject = item.Title.Text;
//                    summary = item.Summary.Text;
//                    x += count + " " + subject + " ";
//                    list.Add(new Tuple<string, string>("Avsnitt " + count + " " + subject, summary));

//                }

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex);
//            }
//            //Datahandler.SavePodFeed(list);
//            return list;
//        }
//    }

//    public class RSSreader
//    {
//        public static List<Tuple<string, string>> rssRead(string url)
//        {
//            string subject = "";
//            string summary = "";
//            var x = "";
//            var y = "";
//            var count = 0;
//            var list = new List<Tuple<string, string>>();
//            try
//            {


//                //string urlX = "http://feeds.soundcloud.com/users/soundcloud:users:298230954/sounds.rss";
//                XmlReader reader = XmlReader.Create(url);
//                SyndicationFeed feed = SyndicationFeed.Load(reader);
//                reader.Close();

//                foreach (SyndicationItem item in feed.Items)
//                {
//                    count++;
//                    subject = item.Title.Text;
//                    summary = item.Summary.Text;
//                    x += count + " " + subject + " ";
//                    list.Add(new Tuple<string, string>("Avsnitt " + count + " " + subject, summary));

//                }

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex);
//            }

//            return list;

//        }
//    }
//}
