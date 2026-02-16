using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Mappings
{
    /// <summary>Mapeamento ProductViewModel → Product (dados do formulário para persistência).</summary>
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>();
        }
    }
}
