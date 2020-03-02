using RestApi_AAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApi_AAW.Controllers
{
    public class TarefasController : ApiController
    {
        public List<Tarefa> Get()
        {
            return Dados.Tarefas;
        }
        public List<Tarefa> Get(int id)
        {
            return Dados.Tarefas.Where(m => m.idTarefa == id).ToList();
        }

        [HttpPost]
        public string tarefa(Tarefa tarefa)
        {
            if (tarefa != null)
            {
                Dados.Tarefas.Add(tarefa);
                return "Tarefa adicionada com sucesso.";
            }
            else
                return "ERRO";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            if (Dados.Tarefas == null && Dados.Tarefas.Count == 0)
                return "Não há tarefas cadastradas para remoção";
            else if (id > 0)
            {
                Tarefa tarefa = Dados.Tarefas.Where(m => m.idTarefa == id).FirstOrDefault();
                Dados.Tarefas.Remove(tarefa);
                return "Tarefa removida com sucesso.";
            }
            else
                return "ERRO";
        }
    }
}
