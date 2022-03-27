using System.Text.RegularExpressions;
using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaJuridica : Pessoa , IPessoaJuridica
    {

        public string ?cnpj { get; set; }

        public string ?razaoSocial { get; set; }
        
            
        public string caminho { get; private set;} = "Database/PessoaJuridica.csv";
        public override float PagarImposto(float rendimento)
        {
            if (rendimento < 3000)
            {
                return rendimento * 0.03f;
            }
            else if (rendimento > 3000 && rendimento <= 6000)
            {
                return rendimento * .05f;
            }
            else if (rendimento > 6000 && rendimento <= 10000)
            {
                return rendimento * .07f;
            }
            else
            {
                return rendimento * .09f;
            }
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


        public void Inserir (PessoaJuridica pj){
            
            VerificarPastaArquivo(caminho);

            string[] pjString = {$"{pj.nome},{pj.cnpj},{pj.razaoSocial}"};

            File.AppendAllLines(caminho, pjString);
        
        }

        public List<PessoaJuridica> Ler(){

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho); // meu arrei é linhas

            foreach (string cadaLinha in linhas)      //foreach ler cada item do arrei, da lista cochetes=arrei é uma lista
            {
                string[] atributos = cadaLinha.Split(",");   //split retorna um arrei de string //divisor entre as strings é a ,
                
                PessoaJuridica cadaPj = new PessoaJuridica();
                
                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listaPj.Add(cadaPj);          
            }

            return listaPj;

        }

    }
}