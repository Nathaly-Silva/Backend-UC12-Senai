// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using CadastroPessoa.Classes;

PessoaFisica novaPf = new PessoaFisica();

//novaPF.nome = "Nathaly";

//Console.WriteLine("Nome: " + novaPF.nome);   //concatenação
//Console.WriteLine($"Nome: {novaPF.nome}");   //interpolação

// Console.WriteLine($"Text");  //cwl + tabe

novaPf.ValidarDataNascimento("01/01/2000");

