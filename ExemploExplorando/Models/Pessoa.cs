using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExemploExplorando.Models
{
    public class Pessoa
    {

        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string sobrenome) // isso é construtor (mesmo nome de sua classe)
        {
            Nome = nome;
            Sobrenome = sobrenome;

            // em maiusculo sao as proprieddes 

        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            // tem q ter o out antes quando for fazer uma Deconstruct
            
            nome = Nome; // a variavel recebe a propriedade pq é maiusculo
            sobrenome = Sobrenome;
        }
        private int _idade;

        private string _sobrenome;
        private string _nome; // agora o nome fica nessa variavel
        public string Nome // propriedade
        {
            get => _nome.ToUpper(); 
            // esse => é um body expression, melhor usar se for retornar algo simples


            // {
            //     return _nome.ToUpper(); // retorna o nome e deixa ele em maiusculo

            // }

            set
            {
                if (value == "") // o value é o que a gnt escreve 
                {
                    throw new ArgumentException("o nome nao pode ser vazio");
                    // faz uma exeção para nao funcionar se o nome for vazio ele nao funcionar 
                }
                _nome = value;
            }
        } 
        public int Idade {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("a idade nao pode ser menor que zero");
                }

                _idade = value;
            } } // propriedade

        public string Sobrenome {

            get => _sobrenome.ToUpper();


            set
            {
                if (value == "")
                {
                    throw new ArgumentException("o sobrenome nao pode estar vazio");
                }

                _sobrenome = value;
            } }

        public String NomeCompleto => $"{Nome} {Sobrenome}";

        public void Apresentar()
        {

            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");

        }
    }
}