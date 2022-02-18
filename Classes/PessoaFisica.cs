using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {

        public string ?cpf { get; set; }

        public string ?dataNascimento { get; set; }
        
        


//        public bool ValidarDataNascimento(DateTime dataNasci)
//        {
//           DateTime dataAtual = DateTime.Today;
//
//            double anos = (dataAtual - dataNasci).TotalDays / 365;

//            if (anos >= 18)
//            {
//                return true;
//           }
//            return false;
//        }
//        
        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
               

                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                 if (anos >= 18)
                 {
                    return true;
                 }

                 return false;
            }

            return false;

        }


        public override float PagarImposto(float rendimento)
         {
            throw new NotImplementedException(); //fica na tela para não dar erro, temporario//
         }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }     
}
   
    
     
