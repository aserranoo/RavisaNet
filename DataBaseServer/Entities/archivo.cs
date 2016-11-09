namespace DataBaseServer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("archivos")]
    public partial class archivo
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [StringLength(15)]
        public string oficina { get; set; }

        [StringLength(7)]
        public string pedimento { get; set; }

        [StringLength(4)]
        public string patente { get; set; }

        [StringLength(3)]
        public string aduana { get; set; }

        [StringLength(30)]
        public string entrada { get; set; }

        [StringLength(30)]
        public string referencia { get; set; }

        [StringLength(150)]
        public string identificador { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string nombre { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tipo { get; set; }

        [Key]
        [Column("archivo", Order = 3)]
        public byte[] archivo1 { get; set; }

        [StringLength(150)]
        public string cliente { get; set; }

        [StringLength(5)]
        public string remesa { get; set; }

        public int? estatus { get; set; }

        public DateTime? fechaModificacion { get; set; }

        public DateTime? fechaCreacion { get; set; }
    }
}
