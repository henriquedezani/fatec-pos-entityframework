using System;

namespace StackOverflow.Models
{
    public class Solucao
    {
        public int SolucaoId { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public int Votos { get; set; }

        public int ProblemaId { get; set; }
        public Problema Problema { get; set; }
    }
}