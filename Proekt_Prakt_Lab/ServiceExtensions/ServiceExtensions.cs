using Proekt_Prakt_Lab.Interfaces.LoadInterfaces;
using Proekt_Prakt_Lab.Interfaces.DisciplineInterfaces;

namespace Proekt_Prakt_Lab.ServicesExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
                services.AddScoped<ILoadService, LoadService>();
                services.AddScoped<IDisciplineService, DisciplineService>();

                return services;
        }
    }
}
