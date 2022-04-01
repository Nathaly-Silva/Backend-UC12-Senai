using CadastroPessoa.Interfaces;
using SA2.Classes;

namespace CadastroPessoa.Classes
{
    public abstract class Pessoa : IPessoa
    {

        public string? nome { get; set;}

        public Endereco? endereco { get; set; }

        public float rendimento { get; set; } // ?rendimento ? não tinha valor atribuido 

        public abstract float PagarImposto(float rendimento);
    
        public void VerificarPastaArquivo(string caminho){
            
            string pasta = caminho.Split("/")[0];
            
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))    //! é o mesmo que  == false
            {
               using (File.Create(caminho)){}
            }
        }    
    
    }
} 
