using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimuladorDeCaixaEletronico.Models
{
    public class ContaBancaria
    {
        public decimal Saldo { get; set; }

        public ContaBancaria(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void DepositarSaldo(decimal valor)
        {
            Saldo += valor;
        }
        
    public void SacarSaldo(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
            else
            {
                Saldo -= valor;
            }
        }
    }
}