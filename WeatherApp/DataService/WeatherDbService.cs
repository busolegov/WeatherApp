using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Interfaces;
using WeatherApp.Models;

namespace WeatherApp.Data
{
    public class WeatherDbService : IDbService
    {
        private ApplicationDbContext _dbContext;
        public WeatherDbService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task SaveWeatherAsync(WeatherCondition weatherCondition) 
        {
            _dbContext.Add(weatherCondition);
            await _dbContext.SaveChangesAsync();
        }



        public async Task<WeatherCondition> GetWeatherByIDAsync(int id) 
        {
            WeatherCondition condition = await _dbContext.WeatherConditions.FirstOrDefaultAsync(x => x.Id == id);
            return condition;
        }

        public IEnumerable<WeatherCondition> GetWeatherConditions(List <WeatherCondition> list) 
        {
            IEnumerable<WeatherCondition> result = _dbContext.WeatherConditions.TakeLast(list.Count);
            return result;
        }


    }
}
