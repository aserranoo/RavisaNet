namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consolidado.UnidadDeNegocioPlantas")]
    public partial class UnidadDeNegocioPlanta
    {
        public int id { get; set; }

        public int? idUnidadDeNegocio { get; set; }

        public int? idCliente { get; set; }

        public int? idSector { get; set; }

        public int? idPlanta { get; set; }

        public int? idRazonSocial { get; set; }

        [StringLength(15)]
        public string IFSRavisa { get; set; }

        public int? idEjecutivo { get; set; }

        public int? idCuenta { get; set; }
    }
}
