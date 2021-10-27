using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using modelss;

namespace DataAccessLayer.Repositories
{
   
    

    public class AvsnittRepository
    {

       
        SerializerForPodcast dataManager;
        List<Podcast> listOfPodcast;
        public AvsnittRepository()
        {
            dataManager = new SerializerForPodcast();
            listOfPodcast = new List<Podcast>();
            listOfPodcast = GetAll();
        }
        
        public List<Podcast> GetAll()
        {
            List<Podcast> listOfPodcasts = new List<Podcast>();

            try
            {
                listOfPodcasts = dataManager.Deserialize();
            }
            catch (Exception)
            {


            }

            return listOfPodcasts;

        }







    }
}
