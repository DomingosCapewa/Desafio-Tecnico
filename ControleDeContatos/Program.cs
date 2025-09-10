using ControleDeContatos.Models;


List<Contato> listaContatos = new List<Contato>
{
    new Contato("Ana", "123456789"),
    new Contato("Bruno", "616161616"),
};



foreach (var c in listaContatos)
{
    c.exibirDados();
}



