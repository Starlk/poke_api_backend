using Newtonsoft.Json;

namespace PokeAPI.model
{
    public class Sprites
    {
        public Species ability { get; set; }

       
        public bool is_hidden { get; set; }

    
        public long slot { get; set; }
      
        public Uri front_shiny { get; set; }
     
        public Uri front_default { get; set; }
    }

}