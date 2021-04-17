using System;
using System.Collections.Generic;
using System.Text;
using VibeTest.Core.InterfacesGenerics;
using VibeTest.Core.Objects.Entities;

namespace VibeTest.Domain.Models
{
    public class Parlamentar : EntityBase, IAggregateRoot
    {
        public Parlamentar() { }
        public Parlamentar(int id, string nome, string partido, string uf, string email)
        {
            Id = id;
            Nome = nome;
            Partido = partido;
            Uf = uf;
            Email = email;
        }
        public string Nome { get; private set; }
        public string Partido { get; private set; }
        public string Uf { get; private set; }
        public string Email { get; private set; }
        public DetalhesParlamentar Detalhes { get; private set; }

        public void SetDetalhesParlamentar(DetalhesParlamentar detalhes)
        {
            this.Detalhes = detalhes;
        }
    }
}
