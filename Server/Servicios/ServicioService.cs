using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tn_prueba_web.Server.Data;
using tn_prueba_web.Shared.Models;

namespace tn_prueba_web.Server.Servicios
{
    public class ServicioService: IServicioService
    {
        private readonly tn_pruebaContext _context;
        public ServicioService(tn_pruebaContext context)
        {
            _context = context;
        }

        public async Task<List<SerServicio>> GetServiciosAsync()
        {
            return await _context.SerServicios.ToListAsync();
        }

        public async Task<List<SerServicio>> GetServiciosPaqueteAsync(int codPaquete)
        {
            if (codPaquete != 0)
            {
                var data = await GetServiciosAsync();
                return data.Where(s => s.SerCodpaq == codPaquete).ToList();
            }
            else
            {
                return await GetServiciosAsync();
            }
        }
    }
}
