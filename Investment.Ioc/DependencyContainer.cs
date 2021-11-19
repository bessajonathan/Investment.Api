using Investment.Core.Interfaces;
using Investment.Core.UseCases;
using Investment.Infra.Data;
using Investment.Infra.Repositories;
using Investment.Infra.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Investment.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IInvestmentDbContext, InvestmentDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Database"));
            });

            services.AddAutoMapper(new Assembly[] { typeof(AutoMapperProfiles).GetTypeInfo().Assembly });

            //Services
            services.AddScoped<IAuthUseCase, AuthUseCase>();
            services.AddScoped<IUserUseCase, UserUseCase>();

            //Repositories
            services.AddScoped<IUserRepository,UserRepository>();
        }
    }
}
