using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerializedAndDeserialized
{
    public class JsonCurrentWeather
    {
        public DateTime observation_time { get; set; } // "03:04 PM",
        public int temperature { get; set; } // -6,
        public double weather_code { get; set; } // 116,        
        public double wind_speed { get; set; } // 19,
        public double wind_degree { get; set; } // 190,   
        public string wind_dir { get; set; } // "S",
        public double pressure { get; set; } // 1018,
        public double precip { get; set; } // 0,    
        public double humidity { get; set; } // 93,    
        public double cloudcover { get; set; } // 50,    
        public double feelslike { get; set; } // -12,   
        public int uv_index { get; set; } // 1,    
        public double visibility { get; set; } // 10,    
        public string is_day { get; set; } // "no"
    }
}
