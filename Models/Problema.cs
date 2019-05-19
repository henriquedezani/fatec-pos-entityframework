using System;
using System.Collections.Generic;

namespace StackOverflow.Models
{
    public class Problema
    {
        public int ProblemaId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }

        public List<Solucao> Solucoes { get; set; }
    }
}