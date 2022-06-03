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
    public class ReservaController : ControllerBase
    {
        readonly IReservaService _reserva;
        public ReservaController(IReservaService reserva)
        {
            _reserva = reserva;
        }

        [HttpPost]
        public async Task<ActionResult<ResReserva>> PostReserva(ResReserva reserva)
        {
            return await _reserva.AddReserva(reserva);
        }
    }
}
