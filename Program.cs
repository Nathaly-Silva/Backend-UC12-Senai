// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//novaPF.nome = "Nathaly";
//Console.WriteLine("Nome: " + novaPF.nome);   //concatenação
//Console.WriteLine($"Nome: {novaPF.nome}");   //interpolação
// Console.WriteLine($"Text");  //cwl + tabe

using CadastroPessoa.Classes;
using SA2.Classes;

Console.WriteLine(@$"
------------------------------------------------
|    Bem vindo(a) ao sistema de cadastro de    |
|          Pessoa Fisica e Juridica            |
------------------------------------------------

");

Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.ForegroundColor = ConsoleColor.Red;

Console.Write("Carregando ");

for (var contador = 0; contador < 10; contador++)
{
    Console.Write(". ");
    Thread.Sleep(500); //500 meio segundo
}

Console.ResetColor();

do          // não sei quantas vezes vou repetir o codigo
{
    Console.Clear();    //limpa o terminal, a parte do Bem vindo! e carregando... é limpa do terminal
    Console.WriteLine(@$"
---------------------------------
|    Selecione uma das opções   |
---------------------------------
|      1 - Pessoa Física        | 
|      2 - Pessoa juriodica     | 
|      0 - Sair                 |
---------------------------------
");

    string? opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":       // não armazenou como inteiro, pois pode digital por exemplo uma letra e "quebrar" o codigo, colocando como string ele cai em defaul
            Console.WriteLine("1 - Pessoa Fisica");
            break;
        case "2":
            break;
        case "0":
            break;

        default:    //caso opção seja invalida, volta a pergunta
            Console.WriteLine($"Opçao inválida, por favor digite uma opção válida");
            break;
    }
} while (true);




// PessoaFisica metodoPf = new PessoaFisica(); //chamar metodo

// PessoaFisica novaPf = new PessoaFisica();
// Endereco novoEnd = new Endereco();

// novaPf.nome = "Nathaly";
// novaPf.dataNascimento = "01/01/2000";
// novaPf.cpf = "123456789";
// novaPf.rendimento = 15000.5f; //float

// novoEnd.logradouro = "Alameda Barão de Lima";
// novoEnd.numero = 519;
// novoEnd.complemento = "SENAI Informatica";
// novoEnd.endComercial = true;

// novaPf.endereco = novoEnd;

// bool dataValida = metodoPf.ValidarDataNascimento(novaPf.dataNascimento);
// //dentro de datavalida esta escrito se é true or False

// //Console.WriteLine($"Nome: {novaPf.nome}");
// //Console.WriteLine($"Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");
// //outra forma
// //colocar @ para quebrade linha,considera todos os caracteres (espaços etc...) como esta no Console.WriteLine
// Console.WriteLine(@$"
// Nome: {novaPf.nome}
// Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
// Maior de idade: {dataValida}
// ");


// validar data de nascimento
// outro exemplo caso seja um projeto pequeno 
//
// não vai usar o bool , colocar metodo em maior idade
//Console.WriteLine(@$"
//Nome: {novaPf.nome}
//Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
//Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)} metodo dentro do Console para aparecer true or false
//");


// PessoaJuridica metodoPj = new PessoaJuridica();

// PessoaJuridica novaPj = new PessoaJuridica();
// Endereco novoEndPj = new Endereco();

// novaPj.nome = "Nome Pj";
// novaPj.cnpj = "00.000.000/0001-00";
// novaPj.razaoSocial = "razão Social Pj";
// novaPj.rendimento = 8000.5f;

// novoEndPj.logradouro = "Alameda Barão de Lima";
// novoEndPj.numero = 519;
// novoEndPj.complemento = "SENAI Informatica";
// novoEndPj.endComercial = true;

// novaPj.endereco = novoEndPj;

// Console.WriteLine(@$"
// Nome: {novaPj.nome}
// Razão Social: {novaPj.razaoSocial}
// CNPJ: {novaPj.cnpj}
// CNPJ Válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");



// //Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0001-00")}"); //Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000100")}");//

