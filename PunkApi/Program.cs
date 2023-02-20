
using PunkApi;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace PunkApp
{   
    internal class Program
    {
      
        static async Task Main(string[] args)
        {
            void PrintProducts(List<Beer> beerStructureList)
            {
                for (var i = 0; i < beerStructureList.Count; i++)
                {
                    Console.WriteLine($"ID: {beerStructureList[i].id}");
                    Console.WriteLine($"Name: {beerStructureList[i].name}");
                    Console.WriteLine($"Description: {beerStructureList[i].description}");
                    Console.WriteLine($"ABV: {beerStructureList[i].abv}");

                }
            }
            
            var client = new PunkClient();
            var products = await client.retrieve("https://api.punkapi.com/v2/beers");
            PrintProducts(products);
            var csvwiz = new PunkCsvWizard();
            csvwiz.Create(products);
            var Readproducts = File.ReadAllLines(@"c:\\temp\\products.csv").Skip(1).ToList();
            Console.WriteLine("Reading...");
            

        }
    }
}
