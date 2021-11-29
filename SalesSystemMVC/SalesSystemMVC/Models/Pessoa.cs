using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace SalesSystemMVC.Models
{
    [Table("PESSOA")]
    public class Pessoa
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NOME")]
        public string Nome { get; set; }
        [Column("CPF")]
        public long CPF { get; set; }
        [Column("ENDERECO")]
        public Endereco Endereco { get; set; }

        [Column("ENDERECO")]
        [ForeignKey("FK_PESSOA_ENDERECO")]
        public int EnderecoId { get; set; }

        public virtual ICollection<PessoaTelefone> PessoaTelefone { get; set; } = new List<PessoaTelefone>();

        [NotMapped]
        public Telefone Telefone { get; set; }
    }
}
