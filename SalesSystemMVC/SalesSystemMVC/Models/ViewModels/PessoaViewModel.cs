namespace SalesSystemMVC.Models.ViewModels
{
    public class PessoaViewModel
    {
        public Pessoa Pessoa { get; set; }
        public Telefone Telefone { get; set; }

        public PessoaViewModel()
        {
            Pessoa = new Pessoa();
            Telefone = new Telefone();
        }
    }
}
