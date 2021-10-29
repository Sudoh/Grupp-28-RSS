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

        public List<Podcast> GetAllPodcasts()
        {
            return podcastRepository.GetAll();

        }

        public List<Avsnitt> GetAllAvsnittFromPodcastByName(string name)
        {

         return podcastRepository.GetPodcastByName(name).DisplayAllaAvsnitt();
   
        }

        public void DeletPodcast(string name)
        {

            int index = podcastRepository.GetIndex(name);
            podcastRepository.Delete(index);
        }

        public void ChangePodcast(string oldName, string newName, int oldIntervall, int newIntervall, string oldKategori, string newKategori)
        {

            Podcast uppdateradPodcast;
            int index = podcastRepository.GetIndex(oldName);

            uppdateradPodcast = new Podcast
            {
                Namn = newName,
                kategori = newKategori,
                UppdateringsIntervall = newIntervall
            };

            podcastRepository.Update(index, uppdateradPodcast);

        }

    }
}
