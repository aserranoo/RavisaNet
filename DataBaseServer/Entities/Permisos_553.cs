namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consolidado.Permisos_553")]
    public partial class Permisos_553
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

        public int? NumPartida { get; set; }

        [StringLength(3)]
        public string ClavePermiso { get; set; }

        [StringLength(40)]
        public string FirmaElectronica { get; set; }

        [StringLength(30)]
        public string NumeroPermiso { get; set; }

        public decimal? ValorComercialdlls { get; set; }

        public decimal? Cantidad { get; set; }
    }
}
