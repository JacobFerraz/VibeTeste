using System;
using System.Collections.Generic;
using System.Text;
using VibeTest.Core.InterfacesGenerics;

namespace VibeTest.Infra.Integration.ResponseModels
{
    public class ParlamentarResponse 
    {
        public IEnumerable<DadoParlamentar> Dados { get; set; }
    }

    public class DadoParlamentar : IResponseModel
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public string Nome { get; set; }
        public string SiglaPartido { get; set; }
        public string UriPartido { get; set; }
        public string SiglaUf { get; set; }
        public int IdLegislatura { get; set; }
        public string UrlFoto { get; set; }
        public string Email { get; set; }
    }
}
