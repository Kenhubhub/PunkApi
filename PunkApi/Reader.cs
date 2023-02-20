using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkApi
{

    public class ProductsCsvReader
    {
        public List<Beer> All()
        {
            using (var reader = new StreamReader(@"c:\\temp\\products.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<Beer>().ToList();
            }
        }
        public Beer Single()
        {
            List<Beer> products = new List<Beer>();
            using (var reader = new StreamReader(@"c:\\temp\\products.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                 csv.GetRecords<Beer>().ToList();
            }
        }
    }
}
