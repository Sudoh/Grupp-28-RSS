using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace modelss
{

        [XmlInclude(typeof(Feed))]
        [XmlInclude(typeof(Avsnitt))]

        public abstract class Podcast
        {
            public string Namn { get; set; }
            public string URLToRSS { get; set; }
            public Podcast()
            {

            }

        }
    }
