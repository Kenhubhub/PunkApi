using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using PunkApi;
using System.Globalization;

namespace PunkRouting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet(Name = "products")]
        public IEnumerable<Beer> Get()
        {


            //using (var reader = new StreamReader(@"c:\\temp\\products.csv"))
            //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    csv.Read();
            //    csv.ReadHeader();
            //    while (csv.Read())
            //    {
            //        var product = new BeerStructure
            //        {
            //            id = csv.GetField<int>("id"),
            //            name = csv.GetField("name"),
            //            description = csv.GetField("description"),
            //            image_url = csv.GetField("image_url"),
            //            abv = csv.GetField<double>("abv")
            //        };
            //        products.Add(product); ;
            //    }
            //}

            return new ProductsCsvReader().All();

            
        }
        
    }
    

}
