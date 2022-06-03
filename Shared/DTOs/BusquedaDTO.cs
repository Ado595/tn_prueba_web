using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tn_prueba_web.Shared.DTOs
{
    public class BusquedaDTO
    {
        [Required]
        public string TextoBusqueda { get; set; }
    }
}
