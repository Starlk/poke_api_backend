using Newtonsoft.Json;

namespace PokeAPI.model
{
    public class pokemons
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Result> results { get; set; }
    }
}
