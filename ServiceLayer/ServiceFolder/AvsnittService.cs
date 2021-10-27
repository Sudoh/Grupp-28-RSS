using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using modelss;



namespace ServiceLayer.ServiceFolder
{
    
    public class AvsnittService

    {
        private readonly AvsnittRepository AvsnittRepo;

        public AvsnittService()
        {
            AvsnittRepo = new AvsnittRepository();
        }


        //static public string updateEpisodeDetails(ListView episodeListview, ListView podcastListview)
        //{


        //    var episodeInfo = getPodcast(podcastListview.SelectedItems[0].Text).EpisodeList.ElementAt(episodeListview.SelectedItems[0].Index);
        //    return episodeInfo.Description + " \n" + episodeInfo.EpisodeLink;

        //}

        public List<Podcast> GetAllPodcasts()
        {
            return AvsnittRepo.GetAll();
        }
        //static public string updateEpisodeDetails(ListView episodeListview, ListView podcastListview)
        //{


        //    var episodeInfo = getPodcast(podcastListview.SelectedItems[0].Text).EpisodeList.ElementAt(episodeListview.SelectedItems[0].Index);
        //    return episodeInfo.Description + " \n" + episodeInfo.EpisodeLink;


        //}
    }
}
