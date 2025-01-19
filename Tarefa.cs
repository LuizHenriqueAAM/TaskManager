using System.Collections.Generic;
namespace Tarefas
{
    public class Tarefas
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        private int _Id { get; set; }
        private string Estado { get; set; }

        public Tarefas(string nome, string descricao, int id, string estado)
        {
            this.Nome = nome = "Blank";
            this.Descricao = descricao = "Blank";
            this._Id = id = 0;
            this.Estado = estado = "Inacabado";
        }

        public static List<Tarefas> ListaDeImcompletas = new List<Tarefas>();
        List<Tarefas> ListaDeCompletas = new List<Tarefas>();

        public override string ToString()
        {
            return $"Tarefa N°: {_Id}, Nome: {Nome}, Descrição: {Descricao}, Estado: {Estado}";
        }
        public static void Adicionar()
        {
            Tarefas objt = new Tarefas(default!, default!, default, default!);
            Console.WriteLine("Informe os dados da tarefa: ");
            Console.Write("Nome: ");
            objt.Nome = Console.ReadLine()!;
            Console.Write("Descrição: ");
            objt.Descricao = Console.ReadLine()!;
            objt._Id = ListaDeImcompletas.Count() + 1;
            ListaDeImcompletas.Add(objt);
        }
        public static void ExibirLista()
        {
            foreach (Tarefas objt in ListaDeImcompletas)
            {
                Console.WriteLine(objt.ToString());
            }
        }
        public static void Deletar()
        {
            Console.WriteLine("Lista de tarefas: ");
            Tarefas.ExibirLista();
            Console.WriteLine("Qual tarefa deseja deletar: (insira o ID)");
            if(!int.TryParse(Console.ReadLine(), out int alvo))
            {
                Console.WriteLine("Entrada inválida! Por Favor, insira um número.");
                return;
            }

            Tarefas? tarefaParaDeletar = ListaDeImcompletas.FistOrDefault(objt => objt._Id == alvo);

            if(tarefaParaDeletar != null)
            {
                ListaDeImcompletas.Remove(tarefaParaDeletar);
                Console.WriteLine($"Tarefa com ID {alvo} deletada com sucesso.");
            }

            for(int i = 0; i < ListaDeImcompletas.Count(); i++)
            {
                ListaDeImcompletas[i]._Id = i + 1;
            }
            
        }
    }
}