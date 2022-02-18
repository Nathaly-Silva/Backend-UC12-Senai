namespace CadastroPessoa.Interfaces
{
    public interface IPessoa
    {
        float PagarImposto(float rendimento);
        bool ValidarDataNascimento(string dataNasc);
    }
}