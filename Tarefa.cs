using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace Tarefas
{
    public class CrudTarefas
    {
        List<CrudTarefas> ListaDeTarefasIncompletas = new List<CrudTarefas>();
        List<CrudTarefas> ListaDeTarefasCompletas = new List<CrudTarefas>();

        public string? nome { get; set; }
        public string? desc { get; set; }
        bool estado { get; set; }
        private int id { get; set; }

        public CrudTarefas(string nome, string desc, bool estado, int id)
        {

            this.nome = nome;
            this.desc = desc;
            this.estado = estado = false;
            this.id = id;
        }
        public string AdicionarNaLista()
        {
            this.id = id + ListaDeTarefasIncompletas.Count() + 1;
            ListaDeTarefasIncompletas.Add(this);
            return $"Tarefa {this.nome} foi adicionada a lista";
        }
        public void ExibirLista()
        {
            foreach (var TarefaNova in ListaDeTarefasIncompletas)
            {
                Console.WriteLine($" Id: {this.id} Nome: {this.nome}");
            }
        }


    }
}