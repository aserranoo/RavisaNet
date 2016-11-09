namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consolidado.Partidas")]
    public partial class Partida
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

        [Required]
        [StringLength(8)]
        public string Fraccion { get; set; }

        public int Numero { get; set; }

        public int SubdivisionFraccion { get; set; }

        [Required]
        [StringLength(250)]
        public string DescripcionMercancia { get; set; }

        public decimal? PrecioUnitario { get; set; }

        public int ValorAduana { get; set; }

        public int ValorComercialPesos { get; set; }

        public decimal? ValorComercialDolares { get; set; }

        public decimal? CantidadUMC { get; set; }

        public int UMC { get; set; }

        public decimal? CantidadTarifa { get; set; }

        public int UMT { get; set; }

        public int ValorAgregado { get; set; }

        [Required]
        [StringLength(1)]
        public string Vinculacion { get; set; }

        public int MetodoValoracion { get; set; }

        [Required]
        [StringLength(20)]
        public string CodigoProducto { get; set; }

        [Required]
        [StringLength(80)]
        public string Marca { get; set; }

        [Required]
        [StringLength(80)]
        public string Modelo { get; set; }

        [Required]
        [StringLength(3)]
        public string PaisOrigenDestino { get; set; }

        [Required]
        [StringLength(3)]
        public string PaisVendedorCompra { get; set; }

        [Required]
        [StringLength(3)]
        public string EntidadFedOrigen { get; set; }

        [Required]
        [StringLength(3)]
        public string EntidadFedDestino { get; set; }

        [Required]
        [StringLength(3)]
        public string EntidadFedComprador { get; set; }

        [Required]
        [StringLength(3)]
        public string EntidadFedVendedor { get; set; }

        [StringLength(30)]
        public string NumeroDeParte { get; set; }

        [StringLength(20)]
        public string OrdenDeCompra { get; set; }

        [StringLength(20)]
        public string Factura { get; set; }

        public int? idCliente { get; set; }
    }
}
