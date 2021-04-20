using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VibeTest.Web.ViewModels
{
    public class ParlamentarDetalhesViewModel
    {
        public string NomeCivil { get; set; }
        public string Foto { get; set; }
        public string Sexo { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Escolaridade { get; set; }
        public IEnumerable<string> RedesSociais { get; set; }
    }
}
