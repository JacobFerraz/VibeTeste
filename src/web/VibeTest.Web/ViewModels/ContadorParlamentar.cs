using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VibeTest.Web.ViewModels
{
    public class ContadorParlamentar
    {
        public int ParlamentarId { get; set; }
        public int Iteracoes { get; set; }

        public ContadorParlamentar(int parlamentarId)
        {
            ParlamentarId = parlamentarId;
        }
    }
}
