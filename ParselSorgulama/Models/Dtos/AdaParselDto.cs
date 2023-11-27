using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParselSorgulama.Models.Dtos
{
    public class AdaParselDto
    {
        public class AdaParsel
        {
            public string type { get; set; }
            public Geometry geometry { get; set; }
            public Properties properties { get; set; }
        }

        public class Geometry
        {
            public string type { get; set; }
            public List<List<List<double>>> coordinates { get; set; }
        }

        public class Properties
        {
            public string ilceAd { get; set; }
            public string mevkii { get; set; }
            public int ilId { get; set; }
            public string durum { get; set; }
            public int ilceId { get; set; }
            public string zeminKmdurum { get; set; }
            public string parselNo { get; set; }
            public string mahalleAd { get; set; }
            public string ozet { get; set; }
            public string gittigiParselListe { get; set; }
            public string gittigiParselSebep { get; set; }
            public string alan { get; set; }
            public string adaNo { get; set; }
            public string nitelik { get; set; }
            public string ilAd { get; set; }
            public int mahalleId { get; set; }
            public string pafta { get; set; }
        }
    }




}
