namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consolidado.Transporte_502")]
    public partial class Transporte_502
    {
        public int id { get; set; }

        [StringLength(4)]
        public string Oficina { get; set; }

        public int? idPedimento { get; set; }

        [StringLength(3)]
        public string Aduana { get; set; }

        [StringLength(4)]
        public string Patente { get; set; }

        [StringLength(13)]
        public string RFC { get; set; }

        [StringLength(18)]
        public string CURP { get; set; }

        [StringLength(120)]
        public string Transportista { get; set; }

        [StringLength(3)]
        public string Pais { get; set; }

        [StringLength(17)]
        public string LineaTransportista { get; set; }

        public int? Bultos { get; set; }

        [StringLength(150)]
        public string Domicilio { get; set; }
    }
}
