using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Data;
using WeatherApp.DataService;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{

    public class WeatherConditionController : Controller
    {
        private readonly ApplicationDbContext _db;

        public WeatherConditionController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> OneDay()
        {
            OneDayApiService oneDayService = new OneDayApiService();
            await oneDayService.GetJsonAsync();
            oneDayService.GetForecastFromJson();
            WeatherCondition condition = new WeatherCondition(oneDayService.OneDayForecast);
            WeatherDbService dbService = new WeatherDbService(_db);
            await dbService.SaveWeatherAsync(condition);
            var result = await dbService.GetWeatherByIDAsync(condition.Id);
            return View(result);
        }

        public async Task<IActionResult> FiveDays() 
        {
            FiveDaysApiService fiveDaysService = new FiveDaysApiService();
            await fiveDaysService.GetJsonAsync();
            fiveDaysService.GetForecastFromJson();
            WeatherCondition condition = new WeatherCondition(fiveDaysService.FiveDaysForecast);
            WeatherDbService dbService = new WeatherDbService(_db);
            List<WeatherCondition> result = new List<WeatherCondition>();
            foreach (var item in condition.ForecastList)
            {
                await dbService.SaveWeatherAsync(item);
                result.Add(item);
            }
            return View(result);
        }

    }
}
