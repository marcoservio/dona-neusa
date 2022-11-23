namespace PastelECia.Models
{
    public class Endereco
    {
        public Endereco()
        {
            Id = 0;
            Locradouro = string.Empty;
            Numero = 0;
            Complemento = string.Empty;
            Bairro = string.Empty;
            Cidade = string.Empty;
            Pais = string.Empty;
            Estado = string.Empty;
            Cep = string.Empty;
        }

        public int Id { get; set; }
        public string Locradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
