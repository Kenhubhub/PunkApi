using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkApi
{

    public class Beers
    {
        public Beers() {
            using (var reader = new StreamReader(@"c:\\temp\\products.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                _Beers = csv.GetRecords<Beer>().ToList();
            }
        }
        public List<Beer> All()
        {
            return _Beers;
        }
        ////public Beer Single()
        ////{
        ////    List<Beer> products = new List<Beer>();
        ////    using (var reader = new StreamReader(@"c:\\temp\\products.csv"))
        ////    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        ////    {
        ////         csv.GetRecords<Beer>().ToList();
        ////    }
        ////}
        public IActionResult Single(int id)
        {
            var Beer = _Beers.SingleOrDefault(p => p.id == id);
            if (Beer == null)
            {
                return new NotFoundResult();
            }
             return new OkObjectResult(Beer);
        }
        private List<Beer> _Beers { get; set; }
    }
}
