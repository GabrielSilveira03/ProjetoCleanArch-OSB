using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Mappings
{
    /// <summary>Mapeamento Product → ProductViewModel (dados vindos do repositório para a tela).</summary>
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
