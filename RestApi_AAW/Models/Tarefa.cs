using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApi_AAW.Models
{
    public class Tarefa
    {
        public Tarefa()
        {
            
        }
        public int idTarefa { get; set; }
        public string descricaoTarefa { get; set; }
        public DateTime dataTarefa { get; set; }
    }
}