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

BarraCarregamento("Carregando ", 500);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;
do          // não sei quantas vezes vou repetir o codigo
{
    Console.Clear();    //limpa o terminal, a parte do Bem vindo! e carregando... é limpa do terminal
    Console.WriteLine(@$"
---------------------------------
|    Selecione uma das opções   |
---------------------------------
|      1 - Pessoa Física        | 
|      2 - Pessoa juridica      | 
|      0 - Sair                 |
---------------------------------
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":       // não armazenou como inteiro, pois pode digital por exemplo uma letra e "quebrar" o codigo, colocando como string ele cai em defaul

            PessoaFisica metodoPf = new PessoaFisica(); //chamar metodo
            
            
            
            string? opcaoPf;
            do
            {
                Console.Clear();    //limpa o terminal, a parte do Bem vindo! e carregando... é limpa do terminal
    Console.WriteLine(@$"
------------------------------------
|       Selecione uma das opções       |
---------------------------------------|
|      1 - Cadastrar Pessoa Física     | 
|      2 - Mostrar Pessoa Fisica       | 
|      0 - Voltar ao menu anterior     |
|______________________________________|
");

                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1" :
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                        novaPf.nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {

                            Console.WriteLine($"Digite a data de nascimento Ex: DD/MM/AAAA");
                            string? dataNasc = Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                            if(dataValida)
                            {
                                novaPf.dataNascimento = dataNasc;
                            }else 
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada invalida, por favor digite uma data valida");
                                Console.ResetColor();
                            }
                        } while (dataValida == false);   
                        
                        
                        Console.WriteLine($"Digite o numero do CPF");
                        novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (digite somente os numeros)");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        
                        Console.WriteLine($"Digite o logradouro");
                        novoEnd.logradouro = (Console.ReadLine());

                        Console.WriteLine($"Digite o numero");
                        novoEnd.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");
                        novoEnd.complemento = Console.ReadLine();
                        
                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEnd.endComercial = true;
                        }else
                        {
                            novoEnd.endComercial = false;
                        }


                        novaPf.endereco = novoEnd;

                        listaPf.Add(novaPf);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Thread.Sleep(3000);
                        Console.ResetColor();

                        break;

                    case "2" :

                        Console.Clear();

                        if(listaPf.Count > 0)
                        {

                            foreach(PessoaFisica cadaPessoa in listaPf)
                            {
   Console.Clear();
                        Console.WriteLine(@$"
Nome: {cadaPessoa.nome}
Endereço: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
Data de Nascimento: {cadaPessoa.dataNascimento}  
Taxa de imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}  
"); 
//"C" moeda R$  - ? "Sim" : "Não" = if se true "sim" se for false "não" IF ternário 

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

                            }

                        }else
                        {
                           Console.WriteLine($"Lista vazia!");
                           Thread.Sleep(3000);
                            
                        }

                        break;

                    case "0" :
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine($"Opçao inválida, por favor digite uma opção válida");
                        Thread.Sleep(2000);
                        break;            
                }

            } while (opcaoPf != "0");

            //bool dataValida = metodoPf.ValidarDataNascimento(novaPf.dataNascimento);
            //dentro de datavalida esta escrito se é true or False

            //Console.WriteLine($"Nome: {novaPf.nome}");
            //Console.WriteLine($"Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");
            //outra forma
            //colocar @ para quebrade linha,considera todos os caracteres (espaços etc...) como esta no Console.WriteLine
            //Console.WriteLine(@$"
            //Nome: {novaPf.nome}
            //Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
            //Maior de idade: {dataValida}
            //");
            //validar data de nascimento, outro exemplo caso seja um projeto pequeno não vai usar o bool , colocar metodo em maior idade

            break;

        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome Pj";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial = "razão Social Pj";
            novaPj.rendimento = 8000.5f;

            novoEndPj.logradouro = "Alameda Barão de Lima";
            novoEndPj.numero = 519;
            novoEndPj.complemento = "SENAI Informatica";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ Válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}
");

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            break;


        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigada por utilizar nosso sistema");

            BarraCarregamento("Finalizando ", 300);

            break;

        default:    //caso opção seja invalida, volta a pergunta
            Console.Clear();
            Console.WriteLine($"Opçao inválida, por favor digite uma opção válida");
            Thread.Sleep(2000);
            break;
    }
} while (opcao != "0"); //opção diferente de 0 , se não vai continuar repetindo , criar essa variavel antes do DO

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.Red;

    Console.Write($"{texto} ");

    for (var contador = 0; contador < 10; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(tempo); //500 meio segundo
    }

    Console.ResetColor();
}




