using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tn_prueba_web.Shared.Models;

namespace tn_prueba_web.Server.Servicios
{
    public interface IPaqueteService
    {
        Task<List<PaqPaquete>> GetPaquetesAsync();
        Task<List<PaqPaquete>> GetPaquetesTipoAsync(int tipo);
    }
}
