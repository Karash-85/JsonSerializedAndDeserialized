using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JsonSerializedAndDeserialized
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = new List<JsonRequest>
            {
                new JsonRequest
                {
                    type = "City",   // город
                    query = "Astana, Kazakhstan",   // Адрес
                    language = "en",  // язык
                    unit = "m"     // единица измерения
                }
            };
            string jsonTextResult = JsonConvert.SerializeObject(request);
            var requestAsResult = JsonConvert.DeserializeObject<List<JsonRequest>>(jsonTextResult);
            
            var locationCountry = new List<JsonLocationCountry>
            {
                new JsonLocationCountry
                {
                    name = "Astana",   // город
                    country = "Kazakhstan",   // Адрес
                    region = "Astana",  // язык
                    lat = 51.181,    // ширина
                    lon = 71.428,    // долгота
                    timezone_id = "Asia\/Almaty",   // часовой пояс
                    localtime = "2021-02-15 21:04",   // местное время
                    localtime_epoc = 1613423040,
                    utc_offset = 6.0,           // Смещение
                }
            };
            string jsonCountryTextResult = JsonConvert.SerializeObject(locationCountry);
            var countryTextResultAsResult = JsonConvert.DeserializeObject<List<JsonRequest>>(jsonCountryTextResult);

            var сurrentWeather = new List<JsonCurrentWeather>
            {
                new JsonCurrentWeather
                {
                    observation_time = "03:04 PM", 
                    temperature = -6,   // Температура
                    weather_code = 116,  // код погоды
                    wind_speed = 19,    // Скорость ветра
                    wind_degree = 190,    // Температура ветра
                    wind_dir = "S",   // Наличие ветра
                    pressure = 1018,   // местное время
                    precip = 0,       // Осадки
                    humidity = 93,    // Влажность
                    cloudcover = 50,    // Облачность
                    feelslike = -12,   // По ощущениям
                    uv_index = 1,   // Индекс УФ
                    visibility = 10,       // Видимость
                    is_day = "no",    // День
                }
            };
            string jsonWeatherTextResult = JsonConvert.SerializeObject(сurrentWeather);
            var WeatherTextResultAsResult = JsonConvert.DeserializeObject<List<JsonRequest>>(jsonWeatherTextResult);
        }

    }
}
