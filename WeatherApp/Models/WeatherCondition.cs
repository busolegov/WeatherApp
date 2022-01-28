using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WeatherCondition
    {
        public WeatherCondition()
        {

        }

        public WeatherCondition(OneDayForecast forecast)
        {
            Temp = forecast.Main.Temp;
            TempFeelsLike = forecast.Main.FeelsLike;
            Pressure = (long?)(forecast.Main.Pressure * 0.75);
            Description = forecast.Weather[0].Description.ToString();
            WindSpeed = forecast.Wind.Speed;
            Humidity = forecast.Main.Humidity;
        }

        public WeatherCondition(FiveDaysForecast forecast)
        {
            foreach (var item in forecast.List)
            {
                ForecastList.Add( new WeatherCondition 
                {
                    Temp = item.Main.Temp,
                    TempFeelsLike = item.Main.FeelsLike,
                    Pressure = (long?)(item.Main.Pressure * 0.75),
                    Description = item.Weather[0].Description.ToString(),
                    WindSpeed = item.Wind.Speed,
                    Humidity = item.Main.Humidity,
                    ForecastDate = item.DtTxt.Value.UtcDateTime,
                }
                );
            }
        }

        [NotMapped]
        public List<WeatherCondition> ForecastList { get; set; } = new List<WeatherCondition>();

        [Key]
        public int Id { get; set; }

        [DisplayName("Время")]
        public DateTime? WeatherDate { get; set; } = DateTime.Now;

        [DisplayName("Город")]
        public string CITY { get; set; } = "Санкт-Петербург";

        [DisplayName("Температура")]
        public double? Temp { get; set; }

        [DisplayName("Температура ощущается как")]
        public double? TempFeelsLike { get; set; }

        [DisplayName("Давление")]
        public long? Pressure { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        [DisplayName("Скорость вестра")]
        public long? WindSpeed { get; set; }

        [DisplayName("Влажность")]
        public long? Humidity { get; set; }

        [DisplayName("Время прогноза")]
        public DateTimeOffset ForecastDate { get; set; }
    }
}
