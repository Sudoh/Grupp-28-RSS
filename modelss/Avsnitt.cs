using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelss
{
    public class Avsnitt
    {
        public string namn { get; set; }

        public string beskrivning { get; set; }

        public Avsnitt(string namn, string beskrivning)
        {
            this.namn = namn;
            this.beskrivning = beskrivning;
        }

        public Avsnitt()
        {

        }
    }
}
