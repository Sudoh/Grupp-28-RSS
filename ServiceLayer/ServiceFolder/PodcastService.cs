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


        public void DownloadPodcast(string url, string namn, string kategori, int uppdateringsFrekvens)
        {

            Podcast podcast = new Podcast();
            podcast.URL = url;
            podcast.Namn = namn;
            podcast.kategori = kategori;
            podcast.UppdateringsIntervall = uppdateringsFrekvens;
            podcastRepository.Create(podcast);

        }


    }
}
