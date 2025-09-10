using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Models
{
    public class Contato
    {

        public string Nome { get; set; }

        public string Telefone { get; set; }
        

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public void exibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine("-----------------------");
        }
    }
}