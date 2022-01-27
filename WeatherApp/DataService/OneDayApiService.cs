using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Interfaces;
using WeatherApp.Models;

namespace WeatherApp.Data
{
    public class OneDayApiService : IApiService
    {

        private const string _APPID = "a85212932f7e291fbcd18a699cdf6167";
        private const string _SPB_CITYID = "498817";

        private static string _oneDayPath = "https://api.openweathermap.org/data/2.5/weather?id="
                                            + _SPB_CITYID + "&units=metric&lang=ru&type=like&APPID=" + _APPID;

        private string _jsonWeather;
        public OneDayForecast OneDayForecast { get; set; }

        public async Task GetJsonAsync() 
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_oneDayPath);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                _jsonWeather = await reader.ReadToEndAsync();
            }
        }

        public void GetForecastFromJson() 
        {
            OneDayForecast = JsonConvert.DeserializeObject<OneDayForecast>(_jsonWeather);
        }
    }
}
