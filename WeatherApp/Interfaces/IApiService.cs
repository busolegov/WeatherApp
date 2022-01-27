using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Interfaces
{
    public interface IApiService
    {
        Task GetJsonAsync ();
        void GetForecastFromJson();
    }
}
