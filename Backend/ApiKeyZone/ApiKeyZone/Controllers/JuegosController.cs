using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;

namespace ApiKeyZone.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JuegosController : ControllerBase
    {
        private readonly IGameRepository _repo;

        
        public JuegosController(IGameRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Juego>>> GetGames()
        {
            var games = await _repo.GetGamesAsync();
            return Ok(games);
        }
        [HttpGet("{id}")] 
        public async Task<ActionResult<Juego>> GetGame(int id)
        {
            var game = await _repo.GetGameByIdAsync(id);
            return Ok(game);
            
                
        }
    }
}
