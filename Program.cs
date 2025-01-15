namespace Tarefas;

class Program
{
    static void Main(string[] args)
    {
        bool saida = false;
        do
        {
            CrudTarefas TarefaNova = new CrudTarefas("Indefinido", "Sem Descrição", false, 0);

            Console.WriteLine("Qual operação deseja fazer: ");
            Console.WriteLine("1-Adicionar Tarefa Na Lista\n3-Sair");
            int escolha = int.Parse(Console.ReadLine()!);
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Informe os dados da tarefa:");
                    Console.Write("Nome: ");
                    TarefaNova.nome = Console.ReadLine();
                    Console.Write("Descrição: ");
                    TarefaNova.desc = Console.ReadLine();
                    Console.WriteLine(TarefaNova.AdicionarNaLista());

                    break;
                case 2:
                    TarefaNova.ExibirLista();
                    break;
                case 3:
                    saida = true;
                    break;
                default:
                    break;
            }
        }
        while (saida == false);
    }
}
