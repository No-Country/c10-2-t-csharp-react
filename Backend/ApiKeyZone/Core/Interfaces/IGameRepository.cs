using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGameRepository
    {
        Task<Juego> GetGameByIdAsync(int id);
        Task<IReadOnlyList<Juego>> GetGamesAsync();
    }
}
