using Newtonsoft.Json;

namespace PokeAPI.model
{
    public class Pokemn
    {

        
        public Ability[] abilities { get; set; }
      
        public Sprites sprites { get; set; }
     
        public Uri location_area_encounters { get; set; }

  
        public Stat[] stats { get; set; }

    
        public string name { get; set; }

        public TypeElement[] types { get; set; }
    }
}