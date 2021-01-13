using Autofac;
using AutoMapper;
using PMESMP.Domain.Core.Interfaces.Repository;
using PMESMP.Domain.Core.Interfaces.Services;
using PMESP.Application;
using PMESP.Application.Interfaces;
using PMESP.Application.Mappers;
using PMESP.Domain.Services;
using PMESP.Infrastructure.Data.Repository;

namespace PMESP.Infrastructure.CrossCutiing
{
    public class ConfigurationIOC
    {
        #region IOC
        public static void Load(ContainerBuilder builder)
        {
            

            builder.RegisterType<ApplicationServiceImportacao>().As<IApplicationServiceImportacao>();
            builder.RegisterType<ServiceImportacao>().As<IServiceImportacao>();
            builder.RegisterType<RepositoryImportacao>().As<IRepositoryImportacao>();
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingPlanilha());
                cfg.AddProfile(new ModelToDtoMappingPlanilha());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }
}
