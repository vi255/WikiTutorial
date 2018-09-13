using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using WikiTutorial.ClienteServices.DTOs;
using WikiTutorial.Entities.ClienteEntity;
using WikiTutorial.Entities.ProductEntity;
using WikiTutorial.ProductServices.DTOs;

namespace WikiTutorial
{
    [DependsOn(typeof(WikiTutorialCoreModule), typeof(AbpAutoMapperModule))]
    public class WikiTutorialApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<CreateProductInput, Product>()
                .ConstructUsing(x => new Product(x.Name, x.Description, x.Size, x.Value));

                config.CreateMap<UpdateProductInput, Product>()
                .ConstructUsing(x => new Product(x.Name, x.Description, x.Size, x.Value));

                config.CreateMap<CreateClienteInput, Cliente>()
                .ConstructUsing(x => new Cliente(x.Name, x.LastName, x.Cpf, x.Idade, x.Email));

                config.CreateMap<UpdateClienteInput, Cliente>()
                .ConstructUsing(x => new Cliente(x.Name, x.LastName, x.Cpf, x.Idade, x.Email));

            });
        }

        public override void Initialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration => {
                configuration.CreateMissingTypeMaps = true;
            });

            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
