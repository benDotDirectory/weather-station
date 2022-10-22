using System.Text.Json.Serialization;

namespace weather_station.Models
{

    /*
     * Model for Ambuient Weather API 'List Devices' endpoint
     */

    public sealed record ListDevicesEndpointResponse
    {

        public sealed record Info
        {
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("coords")]
            public Coordinates Coords { get; set; }
        }

        public sealed record Coordinates
        {
            [JsonPropertyName("address")]
            public string Address { get; set; }

            [JsonPropertyName("coords")]
            public LatitudeLongitude LatLong { get; set; }

            [JsonPropertyName("elevation")]
            public Decimal? Elevation { get; set; }

            [JsonPropertyName("geo")]
            public GeoData? Geo { get; set; }

            [JsonPropertyName("location")]
            public string? Location { get; set; }
        }

        public sealed record GeoData
        {
            [JsonPropertyName("coordinates")]
            public Decimal[] Coordinates { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; }
        }

        public sealed record LatitudeLongitude
        {
            [JsonPropertyName("lat")]
            public Decimal? Latitude { get; set; }

            [JsonPropertyName("lon")]
            public Decimal? Longitude { get; set; }
        }

        [JsonPropertyName("macAddress")]
        public string? MacAddress { get; set; }

        [JsonPropertyName("info")]
        public Info? DeviceInfo { get; set; }

        [JsonPropertyName("lastData")]
        public LastData WeatherData { get; set; }
    }

    // https://github.com/ambient-weather/api-docs/wiki/Device-Data-Specs
    public sealed record LastData
    {
        [JsonPropertyName("baromabsin")]
        public decimal? AbsolutePressureInHg { get; set; }

        [JsonPropertyName("baromrelin")]
        public decimal? RelativePressureInHg { get; set; }

        [JsonPropertyName("batt_co2")]
        public int? CO2BatteryStatus { get; set; }

        [JsonPropertyName("battout")]
        public int? OutdoorBatteryStatus { get; set; }

        [JsonPropertyName("dailyrainin")]
        public decimal? DailyRainInches { get; set; }

        [JsonPropertyName("date")]
        public string? Date { get; set; }

        [JsonPropertyName("dateutc")]
        public long? DateUtc { get; set; }
        
        [JsonPropertyName("dewPoint")]
        public decimal? DewPoint { get; set; }

        [JsonPropertyName("dewPointin")]
        public decimal? IndoorDewPoint { get; set; }

        [JsonPropertyName("eventrainin")]
        public decimal? EventRainIn { get; set; }

        [JsonPropertyName("feelsLike")]
        public decimal? FeelsLike { get; set; }

        [JsonPropertyName("feelsLikein")]
        public decimal FeelsLikeIndoors { get; set; }

        [JsonPropertyName("hourlyrainin")]
        public decimal HourlyRainRateInPerHr { get; set; }

        [JsonPropertyName("humidity")]
        public int? Humidity { get; set; }
        
        [JsonPropertyName("lastRain")]
        public string? LastRain { get; set; }

        [JsonPropertyName("maxdailygust")]
        public decimal? MaxDailyWind { get; set; }

        [JsonPropertyName("monthlyrainin")]
        public decimal? MonthlyRain { get; set; }

        [JsonPropertyName("solarradiation")]
        public decimal? SolarRadiation { get; set; }

        [JsonPropertyName("tempf")]
        public decimal? OutdoorTempature { get; set; }

        [JsonPropertyName("tempinf")]
        public decimal? IndoorTemperature { get; set; }

        [JsonPropertyName("totalrainin")]
        public decimal? TotalRainIn { get; set; }

        [JsonPropertyName("tz")]
        public string? IANATimeZone { get; set; }

        [JsonPropertyName("uv")]
        public decimal? UV { get; set; }

        [JsonPropertyName("weeklyrainin")]
        public decimal? WeeklyRainIn { get; set; }

        [JsonPropertyName("winddir")]
        public decimal? WindDir { get; set; }

        [JsonPropertyName("windgustmph")]
        public decimal? WindGustMph { get; set; }

        [JsonPropertyName("windspeedmph")]
        public decimal? WindSpeedMph { get; set; }

    }
}
