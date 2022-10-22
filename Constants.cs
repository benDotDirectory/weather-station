namespace weather_station
{
    /*
     * Holds constant values
     */

    public class Constants
    {
        // API urls
        private static readonly string ApiBaseiUrl = "https://rt.ambientweather.net/v1";

        public static readonly string ApiListDevicesEndpointRoute = ApiBaseiUrl + "/devices?applicationKey={0}&apiKey={1}";
        public static readonly string ApiDeviceDataEndpointRoute = ApiBaseiUrl + "/devices/{0}?apiKey={1}&applicationKey={2}";

         
    }
}
