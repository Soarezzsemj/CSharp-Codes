using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa // o aluno herda as propriedades dentro da classe pessoa com esse : (nome da classe a ser puxada )
    {
        
        // public Professor () // esse serve se eu nao quiser passar direto e ter mais opções
        // {
        //     
        // }
        public Professor (string nome) : base(nome)
        {
            
        }
        public double Salario { get; set; }

        // public sealed override void Apresentar()
        // {
        //
        //     Console.WriteLine($"Olá, me chamo {Nome}, tenho {Idade} anos e sou professor. meu salario é de {Salario} Reais");
        //
        // }
        public override void Apresentar()
        {

            Console.WriteLine($"Olá, me chamo {Nome}, tenho {Idade} anos e sou professor. meu salario é de {Salario} Reais");

        }
    
    }
}