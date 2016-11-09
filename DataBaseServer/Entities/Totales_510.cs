namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consolidado.Totales_510")]
    public partial class Totales_510
    {
        public int id { get; set; }

        [StringLength(4)]
        public string Oficina { get; set; }

        public int? idPedimento { get; set; }

        [StringLength(3)]
        public string Aduana { get; set; }

        [StringLength(4)]
        public string Patente { get; set; }

        public int? ClaveContrib { get; set; }

        public int? FP { get; set; }

        public int? Importe { get; set; }
    }
}
