﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace modelss
{

  
    [Serializable]

        public class Podcast
    {

        //Podcast
        public string Namn { get; set; }
        public string URL { get; set; }
        public List<Avsnitt> Avsnitt { get; set; }

        public int AntalAvsnitt { get; set; }

        //public Kategori kategori { get; set; }
        public string kategori { get; set; }

        public int UppdateringsIntervall { get; set; }

        public Podcast(string namn, string kategori, string url, int antalAvsnitt, int uppdateringsIntervall, List<Avsnitt> avsnitt)
        {
            Namn = namn;
            this.kategori = kategori;
            URL = url;
            UppdateringsIntervall = uppdateringsIntervall;
            AntalAvsnitt = antalAvsnitt;
            Avsnitt = avsnitt;
        }

        public Podcast()
        {

        }
    }

    }
