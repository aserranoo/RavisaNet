namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consolidado.Facturas")]
    public partial class Factura
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Oficina { get; set; }

        public int idPedimento { get; set; }

        [Required]
        [StringLength(3)]
        public string Aduana { get; set; }

        [Required]
        [StringLength(4)]
        public string Patente { get; set; }

        [Required]
        [StringLength(7)]
        public string NumPedimento { get; set; }

        public DateTime? FechaFactura { get; set; }

        [Required]
        [StringLength(20)]
        public string NumeroFactura { get; set; }

        [StringLength(3)]
        public string TerminoFacturacion { get; set; }

        [StringLength(3)]
        public string MonedaFacturacion { get; set; }

        public decimal? ValorDolares { get; set; }

        public decimal? ValorMonedaExtranjera { get; set; }

        [StringLength(3)]
        public string PaisDeFacturacion { get; set; }

        [StringLength(3)]
        public string EntidadFedFacturacion { get; set; }

        [StringLength(30)]
        public string TaxIDProveedor { get; set; }

        [StringLength(120)]
        public string ProveedorComprador { get; set; }

        [StringLength(80)]
        public string CalleProveedor { get; set; }

        [StringLength(10)]
        public string NumeroIntProveedor { get; set; }

        [StringLength(10)]
        public string NumeroExtProveedor { get; set; }

        [StringLength(10)]
        public string CodigoPostal { get; set; }

        [StringLength(80)]
        public string Ciudad { get; set; }

        [StringLength(200)]
        public string COVE { get; set; }
    }
}
