using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeAPI.model;
using PokeAPI.services;
using System.Text.Json;

namespace PokeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemnController : ControllerBase
    {

        HttpPokemnService pokemnTrainer;

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllPokemons()
        {
            pokemnTrainer = new HttpPokemnService();

            try
            {
                var result = await pokemnTrainer.GetAllPokemon();
                return Ok(result);             

            }catch(Exception ex)
            {
                return BadRequest(ex);
            }
            
       
        }
        [HttpGet("{name}")]
        [ProducesResponseType(typeof(Pokemn),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPokemon(string name)
        {
            pokemnTrainer =  new HttpPokemnService();
            pokemnTrainer.Link = name.ToLower();
            var result  = await pokemnTrainer.GetPokemon();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
