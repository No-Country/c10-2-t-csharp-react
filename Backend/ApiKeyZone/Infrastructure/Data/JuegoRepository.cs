using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class JuegoRepository : IGameRepository
    {
        private readonly KeyZoneContext _context;

        public JuegoRepository(KeyZoneContext context)
        {
           _context = context;
        }

        public async Task<Juego> GetGameByIdAsync(int id)
        {
            return await _context.Juegos
                .Include(P => P.RequisitosMin)
                .Include(P => P.RequisitosRec)
                .FirstOrDefaultAsync(P=> P.Id == id);
        }

        public async Task<IReadOnlyList<Juego>> GetGamesAsync()
        {
            return await _context.Juegos
                .Include(P => P.RequisitosMin)
                .Include(P=> P.RequisitosRec)
                .ToListAsync();
        }
    }
}
