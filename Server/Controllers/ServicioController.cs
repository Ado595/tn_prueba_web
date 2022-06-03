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
    public class ServicioController : ControllerBase
    {
        readonly IServicioService _servicio;
        public ServicioController(IServicioService servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SerServicio>>> Get()
        {
            return await _servicio.GetServiciosAsync();
        }

        [HttpGet("{codPaquete}")]
        public async Task<ActionResult<IEnumerable<SerServicio>>> Get(int codPaquete)
        {
            return await _servicio.GetServiciosPaqueteAsync(codPaquete);
        }
    }
}
