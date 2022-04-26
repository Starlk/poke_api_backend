using PokeAPI.model;
using System.Text.Json;

namespace PokeAPI.services
{
    public class HttpPokemnService
    {
        static readonly HttpClient _client = new HttpClient();
        string _link = "https://pokeapi.co/api/v2/pokemon";
        public string Link { get => _link; set => _link = $"{_link}/{value}"; }

        public async Task<List<Pokemn>> GetAllPokemon()
        {
            var res = await _client.GetAsync(Link);
            var content = await res.Content.ReadAsStringAsync();
            pokemons? pokemonPages = JsonSerializer.Deserialize<pokemons>(content);
            List<Pokemn> pokemns = new  List<Pokemn>();
            for (int i = 0; i < pokemonPages?.results.Count; i++)
            {
                var result = await _client.GetAsync(pokemonPages.results[i].url);
                var mess = await result.Content.ReadAsStringAsync();
                Pokemn? pokemn = JsonSerializer.Deserialize<Pokemn>(mess);
                pokemns.Add(pokemn);
            }
            return pokemns;
        }
        public async Task<Pokemn> GetPokemon()
        {
            try
            {
                var res = await _client.GetAsync(Link);
                var mess = await res.Content.ReadAsStringAsync();
                if (res.IsSuccessStatusCode)
                {
                    Pokemn? poke = JsonSerializer.Deserialize<Pokemn?>(mess);
                    return poke;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}

