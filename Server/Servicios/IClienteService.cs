using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tn_prueba_web.Shared.Models;

namespace tn_prueba_web.Server.Servicios
{
    public interface IClienteService
    {
        Task<List<CliCliente>> GetClientesAsync();
        Task<CliCliente> AddCliente(CliCliente cliente);
    }
}
