namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consolidado.Observaciones_558")]
    public partial class Observaciones_558
    {
        public int id { get; set; }

        [StringLength(4)]
        public string Oficina { get; set; }

        public int? idPedimento { get; set; }

        [StringLength(3)]
        public string Aduana { get; set; }

        [StringLength(4)]
        public string Patente { get; set; }

        public int? Fraccion { get; set; }

        public int? Partida { get; set; }

        public int? Consecutivo { get; set; }

        [StringLength(120)]
        public string Observaciones { get; set; }
    }
}
