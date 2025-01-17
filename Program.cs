namespace Tarefas;

class Program
{
    static void Main(string[] args)
    {
        Tarefas objt = new Tarefas(default!, default!, default, default!);
        Console.WriteLine("Nome:");
        objt.Nome = Console.ReadLine()!;
        Console.WriteLine("Desc:");
        objt.Descricao = Console.ReadLine()!;
        Tarefas.Adicionar(objt);
        Tarefas.ExibirLista();
    }
}
