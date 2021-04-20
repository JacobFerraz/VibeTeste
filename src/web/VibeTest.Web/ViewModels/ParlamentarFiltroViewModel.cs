using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VibeTest.Web.ViewModels
{
    public class ParlamentarFiltroViewModel
    {
        public string Nome { get; set; }
        public string Partido { get; set; }
        public string Uf { get; set; }
        public int Pagina { get; set; }

        public ParlamentarFiltroViewModel(string nome = "", string partido = "", string uf = "", int pagina = 1)
        {
            Nome = nome;
            Partido = partido;
            Uf = uf;
            Pagina = pagina;
        }
    }
}
