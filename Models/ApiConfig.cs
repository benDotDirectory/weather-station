namespace weather_station.Models
{
    /*
     * Holds configuration data used for API calls.
     * - ApplicationKey: create an application https://ambientweather.net/account
     * - ApiKey: create an application https://ambientweather.net/account
     * - MacAddress: (optional), get from making a call to /devices endpoint https://ambientweather.docs.apiary.io/#introduction
     */

    public class ApiConfig
    {
        public string ApplicationKey { get; set; }
        public string ApiKey { get; set; }
        public string MacAddress { get; set; }
    }
}
