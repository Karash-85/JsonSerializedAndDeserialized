using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerializedAndDeserialized
{
    public class JsonRequest
    {
        public string type { get; set; } //"City",
        public string query { get; set; } // "Astana, Kazakhstan",
        public string language { get; set; } // "en",
        public string unit { get; set; } // "m"
    }
}
