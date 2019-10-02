using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokesLibrary
{
    public class JokeGenerator
    {
        // (1)public string GetRandomJokes()
        public async Task<string[]> GetCategories()
        {
            //(1) var client = new HttpClient();
           

            // string randomJoke = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");

            //client.GetStringAsync(https://api.chucknorris.io/jokes/random);

            //(1)return "Will return joke later.";
            //return randomJoke;

            string categoryString = await client.GetStringAsync("https://api.chucknorris.io/jokes/category");
            var categories = JsonConvert.DeserializeObject<string[]>(categoryString);

            return categories;
        }

        public Task<string[]> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
  