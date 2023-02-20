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
            return new Beers().Single(id);  
        }
    }
}
