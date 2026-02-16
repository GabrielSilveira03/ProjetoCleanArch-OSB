using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    /// <summary>Contrato do serviço de aplicação para operações de Produto (CRUD). A apresentação depende apenas desta interface.</summary>
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetProducts();

        Task<ProductViewModel> GetProductById(int? id);

        void Add(ProductViewModel product);

        Task Update(ProductViewModel product);

        void Remove(int Id);
    }
}
