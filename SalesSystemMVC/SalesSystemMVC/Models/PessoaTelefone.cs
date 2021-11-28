using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystemMVC.Models
{
    [Table("PESSOA_TELEFONE")]
    public class PessoaTelefone
    {
        [Key]
        [Column("ID_PESSOA")]
        [ForeignKey("FK_PESSOA")]
        public int PessoaId { get; set; }

        [Key]
        [Column("ID_TELEFONE")]
        [ForeignKey("FK_TELEFONE")]
        public int TelefoneId { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public virtual Telefone Telefone { get; set; }
    }
}
