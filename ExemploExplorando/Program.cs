using ExemploExplorando.Models;
using System.Globalization;


string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");


foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}




















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
