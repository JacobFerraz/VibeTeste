using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VibeTest.Web.ViewModels
{
    public class ParlamentarViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Partido { get; set; }
        public string Uf { get; set; }
        public string Email { get; set; }
        public ParlamentarDetalhesViewModel Detalhes { get; set; }

    }
}
