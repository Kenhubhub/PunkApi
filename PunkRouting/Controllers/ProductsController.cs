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
            return new Beers().All();
            
        }
        
    }
    

}
