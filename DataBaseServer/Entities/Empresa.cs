using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataBaseServer.Entities {
    [Table("Empresas")]
    public partial class Empresa {
        public int EmpresaId { get; set; }
        public string Desc { get; set; }
    }
}