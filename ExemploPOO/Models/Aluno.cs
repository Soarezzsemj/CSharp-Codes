using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa // o aluno herda as propriedades dentro da classe pessoa com esse : (nome da classe a ser puxada )
    {
        // public Aluno () // esse serve se eu nao quiser passar direto e ter mais opções
        // {
        //     
        // }
        public Aluno (string nome) : base(nome)
        {
            
        }
        
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota} ");
        }
    }
    
    
}
