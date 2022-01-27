﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json.Converters;


namespace WeatherApp.Models
{
    public partial class FiveDaysForecast
    {
        //[JsonProperty("cod", NullValueHandling = NullValueHandling.Ignore)]
        //[JsonConverter(typeof(ParseStringConverter))]
        //public long? Cod { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public long? Message { get; set; }

        [JsonProperty("cnt", NullValueHandling = NullValueHandling.Ignore)]
        public long? Cnt { get; set; }

        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public List<List> List { get; set; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public City City { get; set; }
    }

    public partial class City
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("coord", NullValueHandling = NullValueHandling.Ignore)]
        public Coord Coord { get; set; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("population", NullValueHandling = NullValueHandling.Ignore)]
        public long? Population { get; set; }

        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timezone { get; set; }

        [JsonProperty("sunrise", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sunrise { get; set; }

        [JsonProperty("sunset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sunset { get; set; }
    }

    //public partial class Coord
    //{
    //    [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
    //    public double? Lat { get; set; }

    //    [JsonProperty("lon", NullValueHandling = NullValueHandling.Ignore)]
    //    public double? Lon { get; set; }
    //}

    public partial class List
    {
        [JsonProperty("dt", NullValueHandling = NullValueHandling.Ignore)]
        public long? Dt { get; set; }

        [JsonProperty("main", NullValueHandling = NullValueHandling.Ignore)]
        public MainClass Main { get; set; }

        [JsonProperty("weather", NullValueHandling = NullValueHandling.Ignore)]
        public List<Weather> Weather { get; set; }

        [JsonProperty("clouds", NullValueHandling = NullValueHandling.Ignore)]
        public Clouds Clouds { get; set; }

        [JsonProperty("wind", NullValueHandling = NullValueHandling.Ignore)]
        public Wind Wind { get; set; }

        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public long? Visibility { get; set; }

        [JsonProperty("pop", NullValueHandling = NullValueHandling.Ignore)]
        public double? Pop { get; set; }

        [JsonProperty("sys", NullValueHandling = NullValueHandling.Ignore)]
        public Sys Sys { get; set; }

        [JsonProperty("dt_txt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DtTxt { get; set; }

        [JsonProperty("snow", NullValueHandling = NullValueHandling.Ignore)]
        public Snow Snow { get; set; }
    }

    //public partial class Clouds
    //{
    //    [JsonProperty("all", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? All { get; set; }
    //}

    public partial class MainClass
    {
        [JsonProperty("temp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Temp { get; set; }

        [JsonProperty("feels_like", NullValueHandling = NullValueHandling.Ignore)]
        public double? FeelsLike { get; set; }

        [JsonProperty("temp_min", NullValueHandling = NullValueHandling.Ignore)]
        public double? TempMin { get; set; }

        [JsonProperty("temp_max", NullValueHandling = NullValueHandling.Ignore)]
        public double? TempMax { get; set; }

        [JsonProperty("pressure", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pressure { get; set; }

        [JsonProperty("sea_level", NullValueHandling = NullValueHandling.Ignore)]
        public long? SeaLevel { get; set; }

        [JsonProperty("grnd_level", NullValueHandling = NullValueHandling.Ignore)]
        public long? GrndLevel { get; set; }

        [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Humidity { get; set; }

        [JsonProperty("temp_kf", NullValueHandling = NullValueHandling.Ignore)]
        public double? TempKf { get; set; }
    }

    public partial class Snow
    {
        [JsonProperty("3h", NullValueHandling = NullValueHandling.Ignore)]
        public double? The3H { get; set; }
    }

    public partial class Sys
    {
        [JsonProperty("pod", NullValueHandling = NullValueHandling.Ignore)]
        public Pod? Pod { get; set; }
    }

    //public partial class Weather
    //{
    //    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Id { get; set; }

    //    [JsonProperty("main", NullValueHandling = NullValueHandling.Ignore)]
    //    public MainEnum? Main { get; set; }

    //    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    //    public Description? Description { get; set; }

    //    [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
    //    public Icon? Icon { get; set; }
    //}

    //public partial class Wind
    //{
    //    [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
    //    public double? Speed { get; set; }

    //    [JsonProperty("deg", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Deg { get; set; }

    //    [JsonProperty("gust", NullValueHandling = NullValueHandling.Ignore)]
    //    public double? Gust { get; set; }
    //}

    public enum Pod { D, N };

    public enum Description { НебольшойСнег, ОблачноСПрояснениями, Пасмурно };

    public enum Icon { The04D, The04N, The13D, The13N };

    public enum MainEnum { Clouds, Snow };

    //public partial class FiveDaysForecast
    //{
    //    public static FiveDaysForecast FromJson(string json) => JsonConvert.DeserializeObject<FiveDaysForecast>(json, WeatherApp.Models.Converter.Settings);
    //}

    //public static class Serialize
    //{
    //    public static string ToJson(this FiveDaysForecast self) => JsonConvert.SerializeObject(self, WeatherApp.Models.Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            PodConverter.Singleton,
    //            DescriptionConverter.Singleton,
    //            IconConverter.Singleton,
    //            MainEnumConverter.Singleton,
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}

    //internal class ParseStringConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

    //    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.Null) return null;
    //        var value = serializer.Deserialize<string>(reader);
    //        long l;
    //        if (Int64.TryParse(value, out l))
    //        {
    //            return l;
    //        }
    //        throw new Exception("Cannot unmarshal type long");
    //    }

    //    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //    {
    //        if (untypedValue == null)
    //        {
    //            serializer.Serialize(writer, null);
    //            return;
    //        }
    //        var value = (long)untypedValue;
    //        serializer.Serialize(writer, value.ToString());
    //        return;
    //    }

    //    public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    //}

    internal class PodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Pod) || t == typeof(Pod?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "d":
                    return Pod.D;
                case "n":
                    return Pod.N;
            }
            throw new Exception("Cannot unmarshal type Pod");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Pod)untypedValue;
            switch (value)
            {
                case Pod.D:
                    serializer.Serialize(writer, "d");
                    return;
                case Pod.N:
                    serializer.Serialize(writer, "n");
                    return;
            }
            throw new Exception("Cannot marshal type Pod");
        }

        public static readonly PodConverter Singleton = new PodConverter();
    }

    internal class DescriptionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Description) || t == typeof(Description?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "небольшой снег":
                    return Description.НебольшойСнег;
                case "облачно с прояснениями":
                    return Description.ОблачноСПрояснениями;
                case "пасмурно":
                    return Description.Пасмурно;
            }
            throw new Exception("Cannot unmarshal type Description");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Description)untypedValue;
            switch (value)
            {
                case Description.НебольшойСнег:
                    serializer.Serialize(writer, "небольшой снег");
                    return;
                case Description.ОблачноСПрояснениями:
                    serializer.Serialize(writer, "облачно с прояснениями");
                    return;
                case Description.Пасмурно:
                    serializer.Serialize(writer, "пасмурно");
                    return;
            }
            throw new Exception("Cannot marshal type Description");
        }

        public static readonly DescriptionConverter Singleton = new DescriptionConverter();
    }

    internal class IconConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Icon) || t == typeof(Icon?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "04d":
                    return Icon.The04D;
                case "04n":
                    return Icon.The04N;
                case "13d":
                    return Icon.The13D;
                case "13n":
                    return Icon.The13N;
            }
            throw new Exception("Cannot unmarshal type Icon");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Icon)untypedValue;
            switch (value)
            {
                case Icon.The04D:
                    serializer.Serialize(writer, "04d");
                    return;
                case Icon.The04N:
                    serializer.Serialize(writer, "04n");
                    return;
                case Icon.The13D:
                    serializer.Serialize(writer, "13d");
                    return;
                case Icon.The13N:
                    serializer.Serialize(writer, "13n");
                    return;
            }
            throw new Exception("Cannot marshal type Icon");
        }

        public static readonly IconConverter Singleton = new IconConverter();
    }

    internal class MainEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MainEnum) || t == typeof(MainEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Clouds":
                    return MainEnum.Clouds;
                case "Snow":
                    return MainEnum.Snow;
            }
            throw new Exception("Cannot unmarshal type MainEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MainEnum)untypedValue;
            switch (value)
            {
                case MainEnum.Clouds:
                    serializer.Serialize(writer, "Clouds");
                    return;
                case MainEnum.Snow:
                    serializer.Serialize(writer, "Snow");
                    return;
            }
            throw new Exception("Cannot marshal type MainEnum");
        }

        public static readonly MainEnumConverter Singleton = new MainEnumConverter();
    }
}

