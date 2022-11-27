namespace Cfr.Pizzas.Domain.Models
{
    public class Empresa : Entity
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneMovel { get; set; }
        public IEnumerable<Pizza> Pizzas { get; set; }
    }
}
