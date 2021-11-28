using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystemMVC.Models
{
    [Table("TELEFONE_TIPO")]
    public class TipoTelefone
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("TIPO")]
        public int Tipo { get; set; }

        public ICollection<Telefone> Telefones { get; set; } = new List<Telefone>();
    }
}
