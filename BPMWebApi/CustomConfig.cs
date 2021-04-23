using System;
using BMPWebApi.DataAccess.Data;
using BPMWebApi.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BPMWebApi {
    public static class CustomConfig {
        public static void SetUpConfig(IServiceCollection service) {
            SetUpUserRepo(service);
        }
        
        private static void SetUpUserRepo(IServiceCollection service) {
            service.AddScoped<IUserRepo, UserRepoAzureSql>();
        }
        
        public static void SetUpDatabaseAccess(IServiceCollection services, IConfiguration configuration) {
            services.AddDbContext<UserContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("BMPWebApiConnection"),
                    b => {
                    b.MigrationsAssembly("BPMWebApi");
                    });
                // options.UseSqlServer(configuration.GetConnectionString("BMPWebApiConnection"));
                
            });
        }
        
        public static void SetUpAutoMapper(IServiceCollection services) {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        // public static void SetUpAuthentication(IServiceCollection services, IConfiguration configuration) {
        //     services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => {
        //         options.Audience = configuration["AzureActiveDirectory:ResourceId"];
        //         options.Authority = $"{configuration["AzureActiveDirectory:InstanceId"]}{configuration["AzureActiveDirectory:TenantId"]}";
        //     });
        // }
    }
}
