using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tn_prueba_web.Server.Data;
using tn_prueba_web.Shared.Models;

namespace tn_prueba_web.Server.Servicios
{
    public class ClienteService : IClienteService
    {
        private readonly tn_pruebaContext _context;
        public ClienteService(tn_pruebaContext context)
        {
            _context = context;
        }

        public async Task<CliCliente> AddCliente(CliCliente cliente)
        {
            _context.CliClientes.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<List<CliCliente>> GetClientesAsync()
        {
            return await _context.CliClientes.ToListAsync();
        }
    }
}
