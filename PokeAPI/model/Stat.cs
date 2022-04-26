using Newtonsoft.Json;

namespace PokeAPI.model
{
    public class Stat
    {
     
        public long base_stat { get; set; }

     
        public long effort { get; set; }

        public Species stat { get; set; }
    }
}