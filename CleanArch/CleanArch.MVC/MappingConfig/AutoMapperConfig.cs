using CleanArch.Application.Mappings;

namespace CleanArch.MVC.MappingConfig
{
    /// <summary>Registra os perfis de mapeamento da Application (Domain ↔ ViewModel) no container.</summary>
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfig(this IServiceCollection services)
        {
            if(services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
        }
    }
}
