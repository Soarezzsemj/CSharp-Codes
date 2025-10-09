using ExemploExplorando.Models;
using System.Globalization;





Dictionary<string, string> estados = new Dictionary<string, string>(); 
// o primeiro string é o tipo da chave
// segunda string é o valor que vai ser armazenado

estados.Add("SP", "São Paulo");
//SP É A CHAVE E sao paulo so vai ser vinculado A chave
//SAO PAULO É O CONTEUDO ARMAZENADO

estados.Add("BA", "Bahia");
estados.Add("DF", "Brasília");

Console.WriteLine($"Acessando um valor individual pela a chave {estados["DF"]}");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine($"----------------------------------");
estados.Remove("BA");
estados["SP"] = "Sao Paulo - com um novo valor";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{ // ContainsKey é para ver se a chave existe la
    Console.WriteLine($"Valor Existente: {chave}");
}
else
{
    Console.WriteLine($"Valor Não Existente, Adicione a chave: {chave}");
}



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
