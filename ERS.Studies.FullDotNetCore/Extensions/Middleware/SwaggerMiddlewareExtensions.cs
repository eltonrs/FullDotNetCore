using Microsoft.OpenApi.Models;
using System.Reflection;

namespace ERS.Studies.FullDotNetCore.API.Extensions.Middleware
{
    public static class SwaggerMiddlewareExtensions
    {
        public static void AddSwaggerInitialization(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(
                    "v1",
                    new OpenApiInfo
                    {
                        Version = "v1",
                        Title = "API do Elton",
                        Description = "Uma API construída em ASP.Net Core"
                    }
                );

                // Configurar o Swagger para exibir em sua UI os comentários de documentação dos controllers
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
        }

        public static void SwaggerInstall(this WebApplication? app)
        {
            if (app?.Environment.IsDevelopment() is not null)
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
        }
    }
}

/* Source
 * // https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=visual-studio
 */