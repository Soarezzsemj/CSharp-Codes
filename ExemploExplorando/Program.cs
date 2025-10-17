using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;



DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "material", 25.00M, dataAtual);
Venda v2 = new Venda(2, "carro", 125.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);
Console.WriteLine(serializado);
















// IF ELSE NORMAL
// int numero = 20;
//
// if (numero % 2 == 0)
// {
//     Console.WriteLine($"o numero {numero} é par");
// }
// else
// {
//     Console.WriteLine($"o numero {numero} é Impar");
// }


// IF TERNARIO 

// int numero2 = 32;
// bool ehpar = false;
//
// ehpar = numero2 % 2 == 0;
//
// Console.WriteLine($"O numero {numero2} é " + (ehpar ? "par" : "impar"));
 






//DECONSTRUCT
// Pessoa p1 = new Pessoa("Carlos", "Eduardo"); // construtor
//
// (string nome, string sobrenome) = p1; // desconstrutor
//
// Console.WriteLine($"{nome} {sobrenome}");





















// TUPLAS
// (int, string, string) tupla = (18, "Carlos", "Eduardo");
// declara o tipo do dado -> nome da variavel -> e o dado
// outras sintaxes de tuplas
// valuetuple<int, string, string> outroexeplo = (18, "Carlos", "Eduardo");
// var outroexemplo2 = Tuple.Create(18, "Carlos", "Eduardo");

// (int id, string nome, string sobrenome) tupla = (18, "Carlos", "Eduardo");
// declara o tipo do dado com o nome dela-> nome da variavel->e o dado
// Console.WriteLine(tupla.id);
// Console.WriteLine(tupla.nome);
// Console.WriteLine(tupla.sobrenome);
// uma forma de chamar uma tupla o item 1 é o 18, o item 2 é carlos e o 3 é o eduardo



// LeituraArquivo arquivo = new LeituraArquivo();
//
// var (sucesso, linhas, Leituralinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// var (sucesso, linhas, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// se eu quiser descartar algum tipo é so por o _ no lugar

// if (sucesso)
// {
//
//     Console.WriteLine("Quantidade de linhas do arquivo -> " + Leituralinhas);
//     foreach (string leituralinhas in linhas)
//     {
//         Console.WriteLine(leituralinhas);
//     }
//     
// }
// else
// {
//     Console.WriteLine("nao foi possivel ler o arquivo");
// }







// Dictionary<string, string> estados = new Dictionary<string, string>(); 
// // o primeiro string é o tipo da chave
// // segunda string é o valor que vai ser armazenado
//
// estados.Add("SP", "São Paulo");
// //SP É A CHAVE E sao paulo so vai ser vinculado A chave
// //SAO PAULO É O CONTEUDO ARMAZENADO
//
// estados.Add("BA", "Bahia");
// estados.Add("DF", "Brasília");
//
// Console.WriteLine($"Acessando um valor individual pela a chave {estados["DF"]}");
//
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
//
// Console.WriteLine($"----------------------------------");
// estados.Remove
// estados["SP"] = "Sao Paulo - com um novo valor";
//
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
//
// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");
//
// if (estados.ContainsKey(chave))
// { // ContainsKey é para ver se a chave existe la
//     Console.WriteLine($"Valor Existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor Não Existente, Adicione a chave: {chave}");
// }



// Stack<int> pilha = new Stack<int>();
//
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);
//
//
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
//
//
// Console.WriteLine($"Removendo o numero : {pilha.Pop()} com o POP");
//
// pilha.Push(20);
//
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }








// Queue<int> fila = new Queue<int>();
// // chama o queue e tipa o dado no <> e da o nome da variavel
// // faz um new queue e o nome do tipo do dado com o ()
//
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
//
// foreach(int item in fila )
// {
//     Console.WriteLine(item);
//     
// }
//
// Console.WriteLine($"removendo o elemento usando o dequeue: {fila.Dequeue()}");
// // dequeue so passa fechado 
// // remove o primeiro elemento 
// fila.Enqueue(10);
// foreach(int item in fila )
// {
//     Console.WriteLine(item);
//     
// }















// new ExemploExcecao().Metodo1();







// try // ele vai executar o codigo em baixo e se der erro vai passar a exceção para o catch
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
//
// }
// catch (FileNotFoundException ex) // catch filtrado para mostrar a exceção se o arquivo nao foi encontrado
// {
//     Console.WriteLine($"ocorreu um erro, arquivo nao encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"ocorreu um erro, pasta nao encontrada. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"ocorreu um erro. {ex.Message}");
// }
// finally // bloco de codigo ao final do processamento independente se acontecer erro ou nao 
// {
//     Console.WriteLine($"passou, finally agr");
// }






















// string dataString = "2022-12-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);


// Console.WriteLine(data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversao feita com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} nao é uma data valida!");

// }


// Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));
// Console.WriteLine(data.ToLongDateString());



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1382.40M; // QUANDO FOR DECIMAL PRECISA DO "M" NO FINAL

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P2"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// Console.WriteLine($"{valorMonetario:C}");



// string numero1 = "10";

// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);










// Pessoa p1 = new Pessoa(nome :"Carlos", sobrenome: "Eduardo");
// Pessoa p2 = new Pessoa(nome: "Carlin", sobrenome: "Anomalia");

// p1.Nome = "Carlos Eduardo";
// p1.Sobrenome = "Soares";
// p1.Apresentar();

// p2.Nome = "Carlin";
// p2.Sobrenome = "Anomalia";
// p2.Apresentar();

// Curso ingles = new Curso();

// ingles.Nome = "Ingles";

// ingles.Alunos = new List<Pessoa>();

// ingles.AdicionarAluno(p1);
// ingles.AdicionarAluno(p2);
// ingles.ListarAlunos();
