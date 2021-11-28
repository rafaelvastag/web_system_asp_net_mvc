using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystemMVC.Models
{
    [Table("ENDERECO")]
    public class Endereco
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("LOGRADOURO")]
        public string Logradouro { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("CEP")]
        public int CEP { get; set; }
        [Column("BAIRRO")]
        public string Bairro { get; set; }
        [Column("CIDADE")]
        public string Cidade { get; set; }
        [Column("ESTADO")]
        public string Estado { get; set; }

        public ICollection<Pessoa> Pessoas { get; set; } = new List<Pessoa>();
    }
}
