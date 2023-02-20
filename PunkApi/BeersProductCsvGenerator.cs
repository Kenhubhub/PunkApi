using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
namespace PunkApi
{
    public class BeersProductCsvGenerator
    {
        public void CreateCsv(List<Beer> products)
        {
            var stringBuilder = new StringBuilder(); 
            stringBuilder.AppendLine($"id,name,description,image_url,abv");
            stringBuilder.Append(String.Join(Environment.NewLine, products.Select(product => $"{product}")));
            Console.WriteLine(stringBuilder.ToString());
            File.WriteAllText(@"c:\temp\products.csv", stringBuilder.ToString());
            Console.Write("passed through");
        }
    }
}
