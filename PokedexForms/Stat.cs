using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexForms
{
    public class Stat
    {
        [JsonProperty("base_stat")]
        public long BaseStat { get; set; }
        public long Effort { get; set; }
        public Species StatStat { get; set; }

        [JsonProperty("weight")]
        public string weight { get; set; }


    }
}
