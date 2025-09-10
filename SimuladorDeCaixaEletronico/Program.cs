using SimuladorDeCaixaEletronico.Models;


//Depósito
ContaBancaria conta = new ContaBancaria(1000);
Console.WriteLine($"Saldo antes do depósito: {conta.Saldo}");
conta.DepositarSaldo(500);
Console.WriteLine($"Saldo final: {conta.Saldo}");
Console.WriteLine("------------------------------------");

//Saque
Console.WriteLine($"Saldo antes do saque: {conta.Saldo}");
conta.SacarSaldo(200);
Console.WriteLine($"Saldo final: {conta.Saldo}");