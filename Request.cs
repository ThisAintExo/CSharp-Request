using RestSharp;
using System;
using System.Text.Json;

namespace Wow
{
    public class used
    {
        public class DogJson
        {
            public string message { get; set; }
            public string status { get; set; }
        }
        public static void Main(string[] args)
        {
            static void DogReq(String url)
            {
                var client = new RestClient(url);
                var request = new RestRequest(url);
                var response = client.Get(request);

                var response_decoded = JsonSerializer.Deserialize<DogJson>(response.Content);

                Console.WriteLine($"{response_decoded.message} - {response_decoded.status}");
            }

            while (true)
            {
                DogReq("https://dog.ceo/api/breeds/image/random");
            }
        }
    }
}
