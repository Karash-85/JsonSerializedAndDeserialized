using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerializedAndDeserialized
{
    public class JsonLocationCountry
    {
        public string name { get; set; } // "Astana"
        public string country { get; set; } // "Kazakhstan",
        public string region { get; set; } // "Astana",
        public double lat { get; set; } // "51.181",
        public double lon { get; set; } // "71.428",
        public string timezone_id { get; set; } // "Asia\/Almaty",
        public DateTime localtime { get; set; } // "2021-02-15 21:04",
        public int localtime_epoch { get; set; } // 1613423040,
        public double utc_offset { get; set; } // "6.0"
    }
}
