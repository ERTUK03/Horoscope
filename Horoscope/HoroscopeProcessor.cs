using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope
{
    public class HoroscopeProcessor
    {
        public static async Task<HoroscopeModel> LoadHoroscope(string zodiacSign)
        {
            string uri = "https://sameer-kumar-aztro-v1.p.rapidapi.com/?sign=" + zodiacSign + "&day=today";
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(uri),
                Headers =
                {
                    { "X-RapidAPI-Key", "API_KEY" },
                    { "X-RapidAPI-Host", "API_HOST" },
                },
            };

            using (var response = await ApiHelper.ApiClient.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    HoroscopeModel horoscope = await response.Content.ReadAsAsync<HoroscopeModel>();

                    return horoscope;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
