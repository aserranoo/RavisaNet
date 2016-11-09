namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consolidado.Pedimentos")]
    public partial class Pedimento
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Oficina { get; set; }

        [StringLength(4)]
        public string patente { get; set; }

        [Required]
        [StringLength(3)]
        public string Aduana { get; set; }

        [Required]
        [StringLength(7)]
        public string NumPedimento { get; set; }

        public short Tipo { get; set; }

        [Required]
        [StringLength(3)]
        public string ClaveDocumento { get; set; }

        [Required]
        [StringLength(18)]
        public string CURPImportadorExportador { get; set; }

        [StringLength(13)]
        public string RFCImportadorExportador { get; set; }

        [Required]
        [StringLength(18)]
        public string CURPAgAduanalMandatorio { get; set; }

        public decimal? TipoDeCambio { get; set; }

        public int Fletes { get; set; }

        public int Seguros { get; set; }

        public int Embalajes { get; set; }

        public int Otros { get; set; }

        public decimal? Pesobruto { get; set; }

        public short MedioTransporteSalida { get; set; }

        public short MedioTransporteArribo { get; set; }

        public short MedioTransporteEntSalMex { get; set; }

        [Required]
        [StringLength(2)]
        public string DestinoOrigen { get; set; }

        [Required]
        [StringLength(120)]
        public string NombreImportadorExportador { get; set; }

        [Required]
        [StringLength(80)]
        public string CalleImportadorExportador { get; set; }

        [Required]
        [StringLength(10)]
        public string NumeroIntImportadorExportador { get; set; }

        [Required]
        [StringLength(10)]
        public string NumeroExtImportadorExportador { get; set; }

        [Required]
        [StringLength(10)]
        public string CodigoPostal { get; set; }

        [Required]
        [StringLength(80)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(80)]
        public string EntidadFederativa { get; set; }

        [Required]
        [StringLength(3)]
        public string PaisImportadorExportador { get; set; }

        [Required]
        [StringLength(13)]
        public string RFCAgAd { get; set; }

        public int? esRectificacion { get; set; }

        [StringLength(7)]
        public string PedimentoQreq { get; set; }

        [StringLength(4)]
        public string PatenteOriginal { get; set; }

        [StringLength(3)]
        public string AduanaOriginal { get; set; }

        [StringLength(3)]
        public string ClaveDocumentoOriginal { get; set; }

        [StringLength(10)]
        public string FechaOriginal { get; set; }

        [StringLength(20)]
        public string Referencia { get; set; }

        public int? idCliente { get; set; }

        public int? idRazonSocial { get; set; }

        public int? idSector { get; set; }

        public int? idPlanta { get; set; }

        public DateTime? FechaDePago { get; set; }

        public decimal? ValorDolares { get; set; }

        public int? ValorAduanaPesos { get; set; }

        public int? ValorComercialPesos { get; set; }

        public int? IDUnidadDeNegocio { get; set; }

        public short? Estado { get; set; }

        [StringLength(20)]
        public string NumeroDeCuenta { get; set; }

        [StringLength(10)]
        public string ClavePersonal { get; set; }

        [StringLength(10)]
        public string Cliente { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(1)]
        public string Debitado { get; set; }

        public bool? Digitalizado { get; set; }

        public DateTime? FechaLiberacion { get; set; }

        public bool? LigadoAEntrada { get; set; }
    }
}
