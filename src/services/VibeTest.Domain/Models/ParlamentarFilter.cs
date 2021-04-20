using System;
using System.Collections.Generic;
using System.Text;
using VibeTest.Core.InterfacesGenerics;

namespace VibeTest.Domain.Models
{
    public class ParlamentarFilter : IFilterAggregate
    {
        public int Pagina { get; set; }
        public string Nome { get; set; }
        public string Partido { get; set; }
        public string Uf { get; set; }
        public int Id { get; set; }

        public ParlamentarFilter(int pagina, string nome, string partido, string uf, int id)
        {
            Pagina = pagina;
            Nome = nome;
            Partido = partido;
            Uf = uf;
            Id = id;
        }
    }
}
