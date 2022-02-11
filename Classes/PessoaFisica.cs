using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {

        public string ?cpf { get; set; }

        public DateTime ?dataNascimento { get; set; }
        
        
        
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            Console.WriteLine($"{anos}");

            return true;
        }


        public override float PagarImposto(float rendimento)
         {
            throw new NotImplementedException();
         }
    
    }
}
