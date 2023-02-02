using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexForms
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string PokemonName { get; set; }
        [JsonProperty("species")]
        public Species Species { get; set; }
        [JsonProperty("stats")]
        public List<Stat> Stats { get; set; }
        [JsonProperty("url")]
        public Uri Link { get; set; }

        public Pokemon(string pokemonName, Species species, List<Stat> stats, Uri link)
        {
            PokemonName = pokemonName;
            Species = species;
            Stats = stats;
            Link = link;
        }
        public Pokemon() { }
    }
}