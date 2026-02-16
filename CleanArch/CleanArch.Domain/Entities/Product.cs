
namespace CleanArch.Domain.Entities
{
    /// <summary>Entidade de domínio que representa um Produto (núcleo da aplicação, sem dependências externas).</summary>
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
