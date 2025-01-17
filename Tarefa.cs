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
            Console.WriteLine("Qual tarefa deseja deletar: ");
            int alvo = int.Parse(Console.ReadLine()!);
            foreach (Tarefas objt in ListaDeImcompletas)
            {
                if(objt._Id == alvo)
                {
                    ListaDeImcompletas.Remove(objt);
                }
            }
            foreach (Tarefas objt in ListaDeImcompletas)
            {
                objt._Id = objt._Id - 1;
            }
        }
    }
}