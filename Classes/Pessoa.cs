using CadastroPessoa.Interfaces;
using SA2.Classes;

namespace CadastroPessoa.Classes
{
    public abstract class Pessoa : IPessoa
    {

        public string ?nome { get; set;}

        public Endereco? endereco { get; set; }

        public float ?rendimento { get; set; }

        public abstract float PagarImposto(float rendimento);
    }
} 
