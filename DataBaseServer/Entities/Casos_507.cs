namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consolidado.Casos_507")]
    public partial class Casos_507
    {
        public int id { get; set; }

        [StringLength(4)]
        public string Oficina { get; set; }

        public int? idPedimento { get; set; }

        [StringLength(3)]
        public string Aduana { get; set; }

        [StringLength(4)]
        public string Patente { get; set; }

        [StringLength(3)]
        public string Caso { get; set; }

        [StringLength(30)]
        public string Complemento { get; set; }

        [StringLength(30)]
        public string Complemento2 { get; set; }

        [StringLength(30)]
        public string Complemento3 { get; set; }
    }
}
