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

        public static void Adicionar(Tarefas objt)
        {
            ListaDeImcompletas.Add(objt);
        }
        public override string ToString()
        {
            return $"Tarefa N°: {_Id}, Nome: {Nome}, Descrição: {Descricao}, Estado: {Estado}";
        }
        public static void ExibirLista()
        {
            foreach (Tarefas objt in ListaDeImcompletas)
            {
                Console.WriteLine(objt.ToString());
            }
        }

    }
}