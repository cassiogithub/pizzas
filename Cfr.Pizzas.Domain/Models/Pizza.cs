namespace Cfr.Pizzas.Domain.Models
{
    public class Pizza : Entity
    {
        public Guid EmpresaId { get; set; }
        public string Nome { get; set; }
        public TipoPizza Tipo { get; set; }
        public IEnumerable<Ingrediente> Ingredientes{ get; set; }
        public Empresa Empresa { get; set; }
    }
}
