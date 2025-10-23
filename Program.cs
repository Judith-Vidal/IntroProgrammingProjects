using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWeatherApp
{
    internal class Program {

        public partial class Temperatures {
            [JsonProperty("coord")]
            public Coord Coord { get; set; }

            [JsonProperty("wind")]
            public Wind Wind { get; set; }

            [JsonProperty("main")]
            public Temp Temp { get; set; }

            [JsonProperty("weather")]
            public Weather[] Weather { get; set; }
        }

        public partial class Coord {
            [JsonProperty("long")]
            public double Lon { get; set; }

            [JsonProperty("lat")]
            public double Lat { get; set; }
        }
        public partial class Wind {
            [JsonProperty("speed")]
            public double Speed { get; set; }

            [JsonProperty("degree")]
            public double Degree { get; set; }

            [JsonProperty("gust")]
            public double Gust { get; set; }
        }

        public partial class Temp {
            [JsonProperty("temp")]
            public double Tempe { get; set; }

            [JsonProperty("feels_like")]
            public double FL { get; set; }

            [JsonProperty("temp_min")]
            public double Temp_Min { get; set; }

            [JsonProperty("temp_max")]
            public double Temp_Max { get; set; }
        }

        public partial class Weather
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("main")]
            public string Main { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }
        }

        // Check Internet Connection
        public static async Task<string> chkConnection(string url) {
            string code = "";

            // Using the Http Lib to make an Internet Connection
            using (HttpClient client = new HttpClient()) {
                HttpResponseMessage response = await client.GetAsync(url);
                // Checking the Statues Code
                if (response.IsSuccessStatusCode) {
                    code = response.StatusCode.ToString();
                }
                else {
                    code = response.StatusCode.ToString();
                }
                return code;
            }
        
        }

        public static async Task Main(string[] args) {

            string ws = "https://www.google.com";
            string success = await chkConnection(ws);
            string url = "https://api.openweathermap.org/data/2.5/weather?q=";
            string country = "&appid=89b1ef65c8339508f759a5b1ff1765ef&units=imperial";

            HttpClient client = new HttpClient();

            Console.WriteLine("Enter in a City?");
            string city = Console.ReadLine().Trim();
            url = url + city + country;

            //This is the Actual code
            Console.WriteLine(success);
            Console.WriteLine();

            if (success.ToLower() == "ok")
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string respBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(respBody);

                Temperatures dt = JsonConvert.DeserializeObject<Temperatures>(respBody);
                Console.WriteLine(dt.Temp.Tempe.ToString());
            }
            else
            {
                Environment.Exit(0);
            } // End else
        } // End Main

    } // End Class
        
}
