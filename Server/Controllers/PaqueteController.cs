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
    public class PaqueteController : ControllerBase
    {
        readonly IPaqueteService _paquete;
        public PaqueteController(IPaqueteService paquete)
        {
            _paquete = paquete;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaqPaquete>>> Get()
        {
            return await _paquete.GetPaquetesAsync();
        }

        [HttpGet("{tipo}")]
        public async Task<ActionResult<IEnumerable<PaqPaquete>>> Get(int tipo)
        {
            return await _paquete.GetPaquetesTipoAsync(tipo);
        }
    }
}
