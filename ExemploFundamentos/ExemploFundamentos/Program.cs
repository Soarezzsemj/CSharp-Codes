// See https://aka.ms/new-console-template for more information
using ExemploFundamentos.Common.Models;




List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("PI");
listaString.Add("DF");


Console.WriteLine($"intens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("MG");

Console.WriteLine($"intens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("BH");

Console.WriteLine($"intens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("BH");
listaString.Add("BH");
listaString.Add("BH");
listaString.Add("BH");

Console.WriteLine($"intens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");



 for (int contador = 0; contador < listaString.Count; contador++)
 {

     Console.WriteLine($"Posição Numero {contador} - {listaString[contador]}");

 }

 int contadoraForeach = 0;
 foreach (string item in listaString)
 {
    
     Console.WriteLine($"Posição Numero {contadoraForeach} - {item}");
     contadoraForeach++;
 }










// int[] arrayInteiros = new int[5];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 60;
// arrayInteiros[4] = 80;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length); // o copy copia os ngc do primeiro array e joga para a nova array


// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // ele aumenta a capacidade do array

// Console.WriteLine("percorrendo o array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++) // o .length retorna o maximo das casas do array
// {
//     Console.WriteLine($"Posição Numero {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("percorrendo o array com o FOREACH");
// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Numero {contadorForeach} - {valor}");
//     contadorForeach++;
// }


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Carlos Eduardo";
// pessoa1.Idade = 18;
// pessoa1.Apresentar();



// string opcao;
// bool exibirmenu = true;

// while (exibirmenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente ");
//     Console.WriteLine("2 - Buscar cliente ");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirmenu = false; // essa variavel faz a variavel do começo ser falsa e o laço do while fechar e consequentemente fechando o programa
//             //Environment.Exit(0); // fecha o programa esse enviroment.exit(0)
//             break;


//         default:
//             Console.WriteLine("invalido");
//             break;

//     }

// }


//Console.WriteLine("O programa se encerrou");




























// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);



// Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");












// int numero = 5;
// int contador = 0;


// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }










// int numero = 5;



// for (int contador = 0; contador <= 10; contador++) // 3 blocos, declara variavel, condição a ser considerada, ate o numero vai
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}"); // pega o numero da var 5, 
//     // a var contador 0 que vai aumentando com o contador++ e vai printando no laço ate chegar no momento que ela ser falsa
// }
































// Calculadora calc = new Calculadora(); // chamando o método que esta no arquivo da CALCULADORA.CS

// calc.Somar(3, 4);
// calc.Subtrair(34, 5);
// calc.Multiplicar(31, 6);
// calc.Dividir(32, 13);
// calc.Potencia(2, 3);
// calc.Seno(30);
// calc.Coseno(50);
// calc.Tangente(70);
// calc.RaizQuadrada(4);










// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("incrementando o 10");
// numero++;

// Console.WriteLine(numero);

// Console.WriteLine("decrementando o 11");
// numero--;

// Console.WriteLine(numero);























// bool choveu = true;



// bool estaTarde = false;

// if (!choveu && !estaTarde) // o ! inverte o valor, se é true vira false, e se é false vira true, normalmente combina ele na condição com o &&
// {
//     Console.WriteLine("Vou pedalar!");

// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }









// bool presencaMinima = true;

// double media = 7.3;


// if (media >= 7 && presencaMinima) // so funciona se as duas condições forem verdadeira, fora disso vai cair no ELSE 
// {
//     Console.WriteLine("APROVADO");
// } else {
//     Console.WriteLine("REPROVADO");
// }
















// bool maiorIdade = true;

// bool autorizadoResponsavel = false;


// if (maiorIdade || autorizadoResponsavel) // o pipe verifica se pelo menos UMA condição é verdadeira, se nenhuma for a verificação vai para o ELSE
// {
//     Console.WriteLine("Acesso Liberado!");
// }
// else
// {
//     Console.WriteLine("Entrada não Liberada!");
// }























// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     case "A":
//     case "E":
//     case "I":
//     case "O":
//     case "U":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;

// }





























// int quantidadeEstoque = 30;

// int quantidadecompra = 0;

// bool jair = quantidadecompra > 0 && quantidadeEstoque >= quantidadecompra;



// Console.WriteLine($"Quantidade em Estoque: {quantidadeEstoque}");
// Console.WriteLine($"Quantidade de compras: {quantidadecompra}");
// Console.WriteLine($"É possivel realizar a venda? {jair}");


// if (quantidadecompra == 0)
// {
//     Console.WriteLine("Venda invalida, pois não tem produtos");
// }
// else if (quantidadeEstoque >= quantidadecompra)
// {

//     Console.WriteLine("venda realizada");
// }
// else
// {
//     Console.WriteLine("Não tem em estoque, venda não realizada");
// }




// convertendo de maneira segura 

// string a = "151c";

// int b = 0;

// int.TryParse(a, out b); // tenta rodar a variavel A mas se der erro, vai funcionar a variavel B q é zero e nao encerra o programa


// Console.WriteLine(b);
// Console.WriteLine("funcionou garay");


// convertendo de maneira segura 



// int a = 5;
// double b = a;

// long a = 5;
// int b = Convert.ToInt32(a);

// Console.WriteLine(b);



// Cast - Casting (processo de converter)
//int a = Convert.ToInt32 ("5");
//int a = int.Parse("5");

// int inteiro = 5;

// string a = inteiro.ToString();

// Console.WriteLine(a);



// int a = Convert.ToInt32(null);
// int a = int.Parse(null);

// Console.WriteLine(a);


// convert passa o nulo pra ZERO (preferivel essa para nao zuar o programa do cliente)
// o parse da erro 









// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual.ToString("hh:mm:ss"));


// string apresentacao = "olá, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("valor da variaviel quantidade:" + quantidade);
// Console.WriteLine("valor da variaviel altura:" + altura.ToString("0.00"));
// Console.WriteLine("valor da variaviel preço:" + preco);
// Console.WriteLine("valor da variaviel condição:" + condicao);

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "carlo";
// pessoa1.Idade = 18;
// pessoa1.Apresentar();