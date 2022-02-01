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

namespace WeatherApp.DataService
{
    public class FiveDaysApiService : IApiService
    {
        private const string _APPID = "a85212932f7e291fbcd18a699cdf6167";
        private const string _SPB_CITYID = "498817";

        private string _fiveDaysPath = "https://api.openweathermap.org/data/2.5/forecast?id="
                + _SPB_CITYID + "&units=metric&lang=ru&APPID=" + _APPID;

        private string _jsonWeather;
        public FiveDaysForecast FiveDaysForecast { get; set; }

        public void GetForecastFromJson()
        {
            try
            {
                FiveDaysForecast = JsonConvert.DeserializeObject<FiveDaysForecast>(_jsonWeather);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task GetJsonAsync()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_fiveDaysPath);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    _jsonWeather = await reader.ReadToEndAsync();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
