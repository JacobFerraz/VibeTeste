using System;
using System.Collections.Generic;
using System.Text;

namespace VibeTest.Domain.Models
{
    public class DetalhesParlamentar
    {
        public string NomeCivil { get; set; }
        public string Foto { get; set; }
        public string Sexo { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Escolaridade { get; set; }
        public IEnumerable<string> RedesSociais { get; set; }

        public DetalhesParlamentar(string nomeCivil, string foto, string sexo, string dataDeNascimento,
            string escolaridade, IEnumerable<string> redesSociais)
        {
            NomeCivil = nomeCivil;
            Foto = foto;
            Sexo = sexo;
            DataDeNascimento = Convert.ToDateTime(dataDeNascimento);
            Escolaridade = escolaridade;
            RedesSociais = redesSociais;
        }
    }
}
