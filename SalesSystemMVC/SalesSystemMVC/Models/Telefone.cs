using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystemMVC.Models
{
    public class Telefone
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("DDD")]
        public int DDD { get; set; }
        public TipoTelefone TipoTelefone { get; set; }

        [Column("TIPO")]
        [ForeignKey("FK_TELEFONE_TIPO_TELEFONE")]
        public int TipoTelefoneId { get; set; }

        public virtual ICollection<PessoaTelefone> PessoaTelefone { get; set; }
    }
}
