using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tn_prueba_web.Server.Data;
using tn_prueba_web.Shared.Models;

namespace tn_prueba_web.Server.Servicios
{
    public class PaqueteService : IPaqueteService
    {
        private readonly tn_pruebaContext _context;
        public PaqueteService(tn_pruebaContext context)
        {
            _context = context;
        }
        public async Task<List<PaqPaquete>> GetPaquetesAsync()
        {
            return await _context.PaqPaquetes.ToListAsync();
        }

        public async Task<List<PaqPaquete>> GetPaquetesTipoAsync(int tipo)
        {
            if (tipo != 0)
            {
                var data = await GetPaquetesAsync();
                return data.Where(s => s.PaqCodtpaq == tipo).ToList();
            }
            else
            {
                return await GetPaquetesAsync();
            }
        }
    }
}
