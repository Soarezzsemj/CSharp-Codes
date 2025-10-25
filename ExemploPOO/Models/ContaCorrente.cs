using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"seu saque de {saldo} reais foi realizado");
            }
            else
            {
                Console.WriteLine($"saldo insuficiente pois o valor de {valor} do saque supera o seu saldo de {saldo} Reais");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"seu saldo disponivel é de: {saldo} Reais");
        }
        
    }
}
