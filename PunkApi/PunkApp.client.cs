using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace PunkApi
{
    public class PunkClient
    {
        public PunkClient() { }
        public async Task<List<Beer>> retrieve(string API_ENDPOINT)
        {
            HttpClient client = new HttpClient();
            var result = await client.GetAsync(API_ENDPOINT); 
            var stringResult =await result.Content.ReadAsStringAsync();
            Console.WriteLine(stringResult);
            var products = JsonSerializer.Deserialize<List<Beer>>(stringResult);
            return products;
        }
        public List<Beer> products;
    }
}
