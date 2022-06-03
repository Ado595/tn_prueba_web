﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tn_prueba_web.Shared.Models
{
    [Table("estr_estado_res")]
    public partial class EstrEstadoRe
    {
        public EstrEstadoRe()
        {
            ResReservas = new HashSet<ResReserva>();
        }

        [Key]
        [Column("estr_codigo")]
        public int EstrCodigo { get; set; }
        [Column("estr_nombre")]
        [StringLength(25)]
        public string EstrNombre { get; set; }

        [InverseProperty(nameof(ResReserva.ResCodestrNavigation))]
        public virtual ICollection<ResReserva> ResReservas { get; set; }
    }
}