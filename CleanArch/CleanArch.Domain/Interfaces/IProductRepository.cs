using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    /// <summary>Contrato de persistência de Produto. A implementação fica na camada de infraestrutura.</summary>
    public interface IProductRepository
    {
        Task<IEnumerable<Product> >GetProducts();

        Task<Product> GetById(int? id);

        void Add(Product product);

        Task Update(Product product);

        void Remove(int productId);

    }
}
