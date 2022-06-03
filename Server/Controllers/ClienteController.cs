using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tn_prueba_web.Server.Servicios;
using tn_prueba_web.Shared.Models;

namespace tn_prueba_web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        readonly IClienteService _cliente;
        public ClienteController(IClienteService cliente)
        {
            _cliente = cliente;
        }

        [HttpGet("{documento}")]
        public async Task<ActionResult<CliCliente>> GetClienteByDocAsync(string documento)
        {
            if (documento != "")
            {
                var data = await _cliente.GetClientesAsync();
                var cli = data.Where(s => s.CliDocumento == documento).FirstOrDefault();
                return cli != null ? cli : new CliCliente();
            }
            else
            {
                return new CliCliente();
            }
        }

        [HttpPost]
        public async Task<ActionResult<CliCliente>> PostCliente(CliCliente cliente)
        {
            return await _cliente.AddCliente(cliente);
        }
    }
}
