// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




//novaPF.nome = "Nathaly";

//Console.WriteLine("Nome: " + novaPF.nome);   //concatenação
//Console.WriteLine($"Nome: {novaPF.nome}");   //interpolação

// Console.WriteLine($"Text");  //cwl + tabe

using CadastroPessoa.Classes;
using SA2.Classes;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

novaPf.nome = "Nathaly";
novaPf.dataNascimento = "01/01/2000";
novaPf.cpf = "123456789";
novaPf.rendimento = 15000.5f; //float

novoEnd.logradouro = "";



