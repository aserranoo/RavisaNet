namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("general.Pedimentos_Global")]
    public partial class Pedimentos_Global
    {
        public int Id { get; set; }

        public int? IdPedimento { get; set; }

        [StringLength(40)]
        public string BaseOrigen { get; set; }

        [StringLength(3)]
        public string Aduana { get; set; }

        [StringLength(4)]
        public string Patente { get; set; }

        [StringLength(7)]
        public string Pedimento { get; set; }

        [StringLength(5)]
        public string Remesa { get; set; }

        [StringLength(4)]
        public string Oficina { get; set; }

        [StringLength(10)]
        public string Cliente { get; set; }

        public short? Regimen { get; set; }

        [StringLength(3)]
        public string ClavePedimento { get; set; }

        [StringLength(3)]
        public string SOIA000 { get; set; }

        public DateTime? FechaHora000 { get; set; }

        public DateTime? FechaHora110 { get; set; }

        [StringLength(3)]
        public string SOIA100 { get; set; }

        public DateTime? FechaHora100 { get; set; }

        [StringLength(3)]
        public string SOIA300 { get; set; }

        public DateTime? FechaHora300 { get; set; }

        [StringLength(3)]
        public string SOIA400 { get; set; }

        public DateTime? FechaHora400 { get; set; }

        [StringLength(3)]
        public string SOIA500 { get; set; }

        public DateTime? FechaHora500 { get; set; }

        [StringLength(3)]
        public string SOIA600 { get; set; }

        public DateTime? FechaHora600 { get; set; }

        [StringLength(3)]
        public string SOIA700 { get; set; }

        public DateTime? FechaHora700 { get; set; }

        public byte? PedimentoCerrado { get; set; }

        public bool? Imagen { get; set; }

        public bool? Facturado { get; set; }

        [StringLength(40)]
        public string baseArchivoM { get; set; }

        public int? idPedimentoArchivoM { get; set; }

        [StringLength(12)]
        public string Usuario { get; set; }
    }
}
