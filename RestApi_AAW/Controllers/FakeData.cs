using RestApi_AAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApi_AAW.Controllers
{
    public static class FakeData
    {
        public static List<Tarefa> FakeTarefas()
        {
            List<Tarefa> lista = new List<Tarefa>();

            lista.Add(new Tarefa
            {
                idTarefa = 1,
                descricaoTarefa = "Criar código do minicurso",
                dataTarefa = Convert.ToDateTime("2020-02-23 10:20:00")
            }); ;

            lista.Add(new Tarefa
            {
                idTarefa = 2,
                descricaoTarefa = "Criar formulário de inscrição",
                dataTarefa = Convert.ToDateTime("2020-02-10 08:15:00")
            }); ;

            lista.Add(new Tarefa
            {
                idTarefa = 3,
                descricaoTarefa = "Instalar dependências",
                dataTarefa = Convert.ToDateTime("2020-02-05 06:35:00")
            }); ;

            lista.Add(new Tarefa
            {
                idTarefa = 4,
                descricaoTarefa = "Criar slides de apresentação",
                dataTarefa = Convert.ToDateTime("2020-02-02 14:55:00")
            }); ;

            return lista;
        }

    }
}