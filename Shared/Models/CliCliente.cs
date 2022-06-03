﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tn_prueba_web.Shared.Models
{
    [Table("cli_cliente")]
    public partial class CliCliente
    {
        public CliCliente()
        {
            ResReservas = new HashSet<ResReserva>();
        }

        [Key]
        [Column("cli_codigo")]
        public int CliCodigo { get; set; }
        [Column("cli_nombre")]
        [StringLength(20)]
        public string CliNombre { get; set; }
        [Column("cli_documento")]
        [StringLength(20)]
        public string CliDocumento { get; set; }
        [Column("cli_correo")]
        [StringLength(20)]
        public string CliCorreo { get; set; }
        [Column("cli_telefono")]
        [StringLength(20)]
        public string CliTelefono { get; set; }
        [Column("cli_fecha_registro", TypeName = "datetime")]
        public DateTime? CliFechaRegistro { get; set; }

        [InverseProperty(nameof(ResReserva.ResCodcliNavigation))]
        public virtual ICollection<ResReserva> ResReservas { get; set; }
    }
}