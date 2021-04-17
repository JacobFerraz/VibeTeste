using System;
using System.Collections.Generic;
using System.Text;
using VibeTest.Core.InterfacesGenerics;

namespace VibeTest.Infra.Integration.ResponseModels
{
    public class ParlamentarDetalhesResponse 
    {
        public DadosParlamentar Dados { get; set; }
    }
    public class DadosParlamentar : IResponseModel
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public string NomeCivil { get; set; }
        public UltimoStatus UltimoStatus { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public object UrlWebsite { get; set; }
        public List<string> RedeSocial { get; set; }
        public DateTime DataNascimento { get; set; }
        public object DataFalecimento { get; set; }
        public string UfNascimento { get; set; }
        public string MunicipioNascimento { get; set; }
        public string Escolaridade { get; set; }
    }
    public class UltimoStatus
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
        public string Data { get; set; }
        public string NomeEleitoral { get; set; }
        public Gabinete Gabinete { get; set; }
        public string Situacao { get; set; }
        public string CondicaoEleitoral { get; set; }
        public string DescricaoStatus { get; set; }
    }
    public class Gabinete
    {
        public object Nome { get; set; }
        public object Predio { get; set; }
        public object Sala { get; set; }
        public object Andar { get; set; }
        public object Telefone { get; set; }
        public object Email { get; set; }
    }
}
