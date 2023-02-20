using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkApi
{
    public class Beer
    {
        public Beer()
        {

        }
        public Beer(string name) {
            
        }
        public override string ToString()
        {
            return $"{id},{name},\"{description}\",{image_url},{abv}";
        }
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        [JsonProperty("image_url")]
        public string image_url { get; set; }
        public double abv { get; set; }
    }
}
