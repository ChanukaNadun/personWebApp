using Newtonsoft.Json;
using personWebApp.Models;

namespace personWebApp.FruitsApiCall
{
    public class FruitsAPIClass
    {

        public async Task<List<Fruits>> GetDataAsync()
        {
            using (var client = new HttpClient())
            {
                // Replace with your API URL
                var url = "https://localhost:7250/api/Fruits";

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
                var apiResponse = JsonConvert.DeserializeObject<List<Fruits>>(responseString);

                return apiResponse.ToList();

            }
        }

    }
}
