// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




//novaPF.nome = "Nathaly";

//Console.WriteLine("Nome: " + novaPF.nome);   //concatenação
//Console.WriteLine($"Nome: {novaPF.nome}");   //interpolação

// Console.WriteLine($"Text");  //cwl + tabe

using CadastroPessoa.Classes;
using SA2.Classes;

PessoaFisica metodoPf = new PessoaFisica(); //chamar metodo

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

novaPf.nome = "Nathaly";
novaPf.dataNascimento = "01/01/2000";
novaPf.cpf = "123456789";
novaPf.rendimento = 15000.5f; //float

novoEnd.logradouro = "Alameda Barão de Lima";
novoEnd.numero = 519;
novoEnd.complemento = "SENAI Informatica";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

bool dataValida = metodoPf.ValidarDataNascimento(novaPf.dataNascimento);
//dentro de datavalida esta escrito se é true or False

//Console.WriteLine($"Nome: {novaPf.nome}");
//Console.WriteLine($"Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");
//outra forma
//colocar @ para quebrade linha,considera todos os caracteres (espaços etc...) como esta no Console.WriteLine
Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {dataValida}
");


// validar data de nascimento
// outro exemplo caso seja um projeto pequeno 
//
// não vai usar o bool , colocar metodo em maior idade
//Console.WriteLine(@$"
//Nome: {novaPf.nome}
//Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
//Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)} metodo dentro do Console para aparecer true or false
//");
