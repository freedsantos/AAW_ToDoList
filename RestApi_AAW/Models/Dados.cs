using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestApi_AAW.Controllers;

namespace RestApi_AAW.Models
{
    public static class Dados
    {
        public static List<Tarefa> Tarefas = FakeData.FakeTarefas();
    }
}