using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelss
{
    public class Feed
    {
        public string URL { get; set; }

        public Kategori kategori { get; set; }

        public List<Avsnitt> avsnitt { get; set; }

        public string namn { get; set; }

        public int uppIntervall { get; set; }

        public int antalAvsnitt { get; set; }

        public Feed(string URL, Kategori kategori, List<Avsnitt> avsnitt, string namn, int uppIntervall, int antalAvsnitt)
        {
            this.URL = URL;
            this.kategori = kategori;
            this.avsnitt = avsnitt;
            this.namn = namn;
            this.uppIntervall = uppIntervall;
            this.antalAvsnitt = antalAvsnitt;
        }

        public Feed()
        {

        }
    }
}
