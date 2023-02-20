using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using PunkApi;
using System.Globalization;
using System.Xml.Linq;

namespace PunkRouting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet("product/{id}")]
        public IActionResult Get(int id)
        {
            var product = new Beer();
            //using (var reader = new StreamReader(@"c:\\temp\\products.csv"))
            //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    var products = csv.GetRecords<Beer>().ToList();
            //    product = products.SingleOrDefault (p => p.id == id);
            //    if(product == null)
            //    {
            //        return new NotFoundResult();
            //    }
            //}
            var products = new ProductsCsvReader().All();
            product = products.SingleOrDefault(p => p.id == id);
            if(product == null)
            {
                    return new NotFoundResult();
            }
            return new OkObjectResult(product);
        }
    }
}
