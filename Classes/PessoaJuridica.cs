using System.Text.RegularExpressions;
using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaJuridica : Pessoa , IPessoaJuridica
    {

        public string ?cnpj { get; set; }

        public string ?razaoSocial { get; set; }
        
            

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
        //xx.xxx.xxx/0001-xx xxxxxxxx0001xx
        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))    //documentação regex// // | = ou //
            {
                if (cnpj.Length == 18)    //Length - tamanho -  quantos caracteres tem a string(cnpj)//
                {
                    if (cnpj.Substring(11, 4) == "0001") //11 caracteres até chegar no 0001 e 4 numero do tamanho da string especifica//
                    {
                        return true;
                    }
                   
                }
                else if (cnpj.Length == 14) 
                {
                    if(cnpj.Substring(8,4) == "0001")
                    {
                        return true;
                    }
                
                }    
            }

            return false;
        }
    }
}