using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasarimWebSayfa.Models
{
    public class Telefon
    {
        public string marka { get; set; }
        public string model { get; set; }
        public string os { get; set; }
        public float dahiliHaf { get; set; }
        public float ram { get; set; }
        public float arkKam { get; set; }
        public string garanti { get; set; }
        public string renk { get; set; }
        public float ekranBoyutu { get; set; }
        public float onKam { get; set; }

        public string mlModel { get; set; }

        public Telefon()
        {
            marka = "Belirtilmemiş";
            model = "Belirtilmemiş";
            os = "Belirtilmemiş";
            dahiliHaf = 0;
            ram = 0;
            arkKam = 0;
            garanti = "Belirtilmemiş";
            renk = "Belirtilmemiş";
            ekranBoyutu = 0;
            onKam = 0;
            mlModel = "knn";

        }

    }
}