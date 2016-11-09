namespace DataBaseServer.Entities {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PRDRavisa : DbContext {
        public PRDRavisa ()
            : base("name=PRDRavisa") {
        }

        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Partida> Partidas { get; set; }
        public virtual DbSet<Pedimento> Pedimentos { get; set; }
        public virtual DbSet<Pedimentos_Global> Pedimentos_Global { get; set; }
        public virtual DbSet<Casos_507> Casos_507 { get; set; }
        public virtual DbSet<Casos_554> Casos_554 { get; set; }
        public virtual DbSet<Contenedores_504> Contenedores_504 { get; set; }
        public virtual DbSet<Diferencias_702> Diferencias_702 { get; set; }
        public virtual DbSet<Fechas_506> Fechas_506 { get; set; }
        public virtual DbSet<Gravamen_557> Gravamen_557 { get; set; }
        public virtual DbSet<Guias_503> Guias_503 { get; set; }
        public virtual DbSet<Observaciones_558> Observaciones_558 { get; set; }
        public virtual DbSet<PartidaContrib_556> PartidaContrib_556 { get; set; }
        public virtual DbSet<Permisos_553> Permisos_553 { get; set; }
        public virtual DbSet<Totales_509> Totales_509 { get; set; }
        public virtual DbSet<Totales_510> Totales_510 { get; set; }
        public virtual DbSet<Transporte_502> Transporte_502 { get; set; }
        public virtual DbSet<UnidadDeNegocioPlanta> UnidadDeNegocioPlantas { get; set; }
        public virtual DbSet<archivo> archivos { get; set; }

        protected override void OnModelCreating (DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Factura>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.NumPedimento)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.NumeroFactura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.TerminoFacturacion)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.MonedaFacturacion)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.ValorDolares)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Factura>()
                .Property(e => e.ValorMonedaExtranjera)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Factura>()
                .Property(e => e.PaisDeFacturacion)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.EntidadFedFacturacion)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.TaxIDProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.ProveedorComprador)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.CalleProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.NumeroIntProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.NumeroExtProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.CodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.COVE)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.NumPedimento)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.Fraccion)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.DescripcionMercancia)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.PrecioUnitario)
                .HasPrecision(20, 5);

            modelBuilder.Entity<Partida>()
                .Property(e => e.ValorComercialDolares)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Partida>()
                .Property(e => e.CantidadUMC)
                .HasPrecision(15, 3);

            modelBuilder.Entity<Partida>()
                .Property(e => e.CantidadTarifa)
                .HasPrecision(15, 3);

            modelBuilder.Entity<Partida>()
                .Property(e => e.Vinculacion)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.CodigoProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.Marca)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.PaisOrigenDestino)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.PaisVendedorCompra)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.EntidadFedOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.EntidadFedDestino)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.EntidadFedComprador)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.EntidadFedVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.NumeroDeParte)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.OrdenDeCompra)
                .IsUnicode(false);

            modelBuilder.Entity<Partida>()
                .Property(e => e.Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.patente)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.NumPedimento)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.ClaveDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.CURPImportadorExportador)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.RFCImportadorExportador)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.CURPAgAduanalMandatorio)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.TipoDeCambio)
                .HasPrecision(9, 5);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.Pesobruto)
                .HasPrecision(14, 3);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.DestinoOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.NombreImportadorExportador)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.CalleImportadorExportador)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.NumeroIntImportadorExportador)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.NumeroExtImportadorExportador)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.CodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.EntidadFederativa)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.PaisImportadorExportador)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.RFCAgAd)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.PedimentoQreq)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.PatenteOriginal)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.AduanaOriginal)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.ClaveDocumentoOriginal)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.FechaOriginal)
                .IsFixedLength();

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.NumeroDeCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.ClavePersonal)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimento>()
                .Property(e => e.Debitado)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.BaseOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.Pedimento)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.ClavePedimento)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.SOIA000)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.SOIA100)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.SOIA300)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.SOIA400)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.SOIA500)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.SOIA600)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.SOIA700)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.baseArchivoM)
                .IsUnicode(false);

            modelBuilder.Entity<Pedimentos_Global>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_507>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_507>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_507>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_507>()
                .Property(e => e.Caso)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_507>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_507>()
                .Property(e => e.Complemento2)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_507>()
                .Property(e => e.Complemento3)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_554>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_554>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_554>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_554>()
                .Property(e => e.Caso)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_554>()
                .Property(e => e.Complemento1)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_554>()
                .Property(e => e.Complemento2)
                .IsUnicode(false);

            modelBuilder.Entity<Casos_554>()
                .Property(e => e.Complemento3)
                .IsUnicode(false);

            modelBuilder.Entity<Contenedores_504>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Contenedores_504>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Contenedores_504>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Contenedores_504>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Diferencias_702>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Diferencias_702>()
                .Property(e => e.Pedimento)
                .IsUnicode(false);

            modelBuilder.Entity<Diferencias_702>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Diferencias_702>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Fechas_506>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Fechas_506>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Fechas_506>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Gravamen_557>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Gravamen_557>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Gravamen_557>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Guias_503>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Guias_503>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Guias_503>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Guias_503>()
                .Property(e => e.GuiaPackingList)
                .IsUnicode(false);

            modelBuilder.Entity<Guias_503>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Observaciones_558>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Observaciones_558>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Observaciones_558>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Observaciones_558>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<PartidaContrib_556>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<PartidaContrib_556>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<PartidaContrib_556>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<PartidaContrib_556>()
                .Property(e => e.Tasa)
                .HasPrecision(15, 10);

            modelBuilder.Entity<Permisos_553>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos_553>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos_553>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos_553>()
                .Property(e => e.ClavePermiso)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos_553>()
                .Property(e => e.FirmaElectronica)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos_553>()
                .Property(e => e.NumeroPermiso)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos_553>()
                .Property(e => e.ValorComercialdlls)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Permisos_553>()
                .Property(e => e.Cantidad)
                .HasPrecision(15, 3);

            modelBuilder.Entity<Totales_509>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Totales_509>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Totales_509>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Totales_509>()
                .Property(e => e.Importe)
                .HasPrecision(15, 10);

            modelBuilder.Entity<Totales_510>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Totales_510>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Totales_510>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_502>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_502>()
                .Property(e => e.Aduana)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_502>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_502>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_502>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_502>()
                .Property(e => e.Transportista)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_502>()
                .Property(e => e.Pais)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_502>()
                .Property(e => e.LineaTransportista)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_502>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UnidadDeNegocioPlanta>()
                .Property(e => e.IFSRavisa)
                .IsUnicode(false);

            modelBuilder.Entity<archivo>()
                .Property(e => e.oficina)
                .IsUnicode(false);

            modelBuilder.Entity<archivo>()
                .Property(e => e.pedimento)
                .IsUnicode(false);

            modelBuilder.Entity<archivo>()
                .Property(e => e.patente)
                .IsUnicode(false);

            modelBuilder.Entity<archivo>()
                .Property(e => e.aduana)
                .IsUnicode(false);

            modelBuilder.Entity<archivo>()
                .Property(e => e.entrada)
                .IsUnicode(false);

            modelBuilder.Entity<archivo>()
                .Property(e => e.referencia)
                .IsUnicode(false);

            modelBuilder.Entity<archivo>()
                .Property(e => e.identificador)
                .IsUnicode(false);

            modelBuilder.Entity<archivo>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<archivo>()
                .Property(e => e.cliente)
                .IsUnicode(false);

            modelBuilder.Entity<archivo>()
                .Property(e => e.remesa)
                .IsUnicode(false);
        }
    }
}
