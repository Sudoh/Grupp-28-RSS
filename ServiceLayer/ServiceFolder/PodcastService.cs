using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelss;
using DataAccessLayer.Repositories;

namespace ServiceLayer.ServiceFolder
{
    public class PodcastService
    {
        IPodcastRepository<Podcast> podcastRepository;

        public PodcastService()
        {
            podcastRepository = new PodcastRepository();
        }


        public void DownloadPodcast(string url)
        {

            url = null;
            Podcast podcast = new Podcast();
            podcast.URL = "https://spelkosmos.se/alla-episoder.rss";
            podcastRepository.Create(podcast);

        }


    }
}
