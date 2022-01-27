using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Interfaces
{
    interface IDbService
    {
        Task SaveWeatherAsync(WeatherCondition weatherCondition);
        Task<WeatherCondition> GetWeatherByIDAsync(int id);
        IEnumerable<WeatherCondition> GetWeatherConditions(List<WeatherCondition> list);
    }
}
