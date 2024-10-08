using Newtonsoft.Json;
using personWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace personWebApp.HerosApiCall
{
    
    public class HerosAPIClass
    {

        public async Task<List<Heros>> GetDataAsync()
        {
            using (var client = new HttpClient())
            {
                // Replace with your API URL
                var url = "https://localhost:7250/api/Heros";

                // Send the GET request
                var response = await client.GetAsync(url);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Read the response
                var responseString = await response.Content.ReadAsStringAsync();
                // Console.WriteLine(responseString);

                ////// featch data in a class //////
                var responseS = await response.Content.ReadAsStringAsync();

                // Deserialize the response to ApiResponse object
                var apiResponse = JsonConvert.DeserializeObject<List<Heros>>(responseString);

                return apiResponse.ToList();

            }
        }
    }
}
