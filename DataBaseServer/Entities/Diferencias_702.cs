namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consolidado.Diferencias_702")]
    public partial class Diferencias_702
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Oficina { get; set; }

        public int? idPedimento { get; set; }

        [StringLength(7)]
        public string Pedimento { get; set; }

        [StringLength(3)]
        public string Aduana { get; set; }

        [StringLength(4)]
        public string Patente { get; set; }

        public int? Gravamen { get; set; }

        public int? FP { get; set; }

        public int? importe { get; set; }
    }
}
