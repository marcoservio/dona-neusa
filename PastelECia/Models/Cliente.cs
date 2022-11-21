namespace PastelECia.Models
{
    public class Cliente
    {
        public Cliente()
        {
            Id = 0;
            Nome = string.Empty;
            CnpjCpf = string.Empty;
            Telefone = string.Empty;
            Email = string.Empty;
            Endereco = new Endereco();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CnpjCpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}
