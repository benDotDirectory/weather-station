using System.Net;
using System.Text.Json;
using weather_station.Models;

namespace weather_station.Services
{
    public class AmbientWeatherService
    {
        public async Task<ListDevicesEndpointResponse> ListDevices(ApiConfig config)
        {
            var url = string.Format(Constants.ApiListDevicesEndpointRoute, config.ApplicationKey, config.ApiKey);
            string response;

            using (var httpClient = new HttpClient())
            {
                var resp = httpClient.GetAsync(url).Result;

                if (resp.IsSuccessStatusCode)
                {
                    response = await resp.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new HttpRequestException("Bad Request");
                }
            }

            return JsonSerializer.Deserialize<List<ListDevicesEndpointResponse>>(response).FirstOrDefault();
        }

        //public Task<DeviceDataEndpointResponse> QueryDevice()
        //{
        //    throw new NotImplementedException("This endpoint seems to be broken on Ambient Weather's side - returns empty response body from API");
        //}
        
    }
}
