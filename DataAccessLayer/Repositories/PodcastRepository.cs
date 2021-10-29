﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelss;
using DataAccesLayer;

namespace DataAccessLayer.Repositories
{
      
    public class PodcastRepository : IPodcastRepository<Podcast>
    {
        SerializerForPodcast dataManager;
        List<Podcast> listOfPodcasts;
        RSSReader feedDownloader;

        public PodcastRepository()
        {
            dataManager = new SerializerForPodcast();
            listOfPodcasts = new List<Podcast>();
            feedDownloader = new RSSReader();
       
            listOfPodcasts = GetAll();
        }

  
        public void Create(Podcast entity)
        {
            Podcast podcast = new Podcast {

                Avsnitt = feedDownloader.RssRead(entity.URL.ToString()),
                AntalAvsnitt = feedDownloader.RssRead(entity.URL.ToString()).Count,
                kategori = entity.kategori,
                Namn = entity.Namn,
                UppdateringsIntervall = entity.UppdateringsIntervall,
                URL = entity.URL

            };
            listOfPodcasts.Add(podcast);
            SaveChanges();
        }


        public void Delete(int index)
        {
            listOfPodcasts.RemoveAt(index);
            SaveChanges();

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

        public int GetIndex(string name)
        {
           return GetAll().FindIndex(e => e.Namn.Equals(name));
        }

        public Podcast GetPodcastByName(string name)
        {
            return GetAll().FirstOrDefault(p => p.Namn.Equals(name));
        }

        public void SaveChanges()
        {
            
            dataManager.Serialize(listOfPodcasts);
        }

        public void Update(int index, Podcast entity)
        {
            listOfPodcasts[index].Namn = entity.Namn.ToString();
            listOfPodcasts[index].kategori = entity.kategori.ToString();
            listOfPodcasts[index].UppdateringsIntervall = entity.UppdateringsIntervall;

            SaveChanges();
        }
    }
}
