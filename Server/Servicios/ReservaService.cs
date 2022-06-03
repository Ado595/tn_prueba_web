using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tn_prueba_web.Server.Data;
using tn_prueba_web.Shared.Models;

namespace tn_prueba_web.Server.Servicios
{
    public class ReservaService : IReservaService
    {
        private readonly tn_pruebaContext _context;
        public ReservaService(tn_pruebaContext context)
        {
            _context = context;
        }
        public async Task<ResReserva> AddReserva(ResReserva reserva)
        {
            _context.ResReservas.Add(reserva);
            await _context.SaveChangesAsync();
            return reserva;
        }
    }
}
