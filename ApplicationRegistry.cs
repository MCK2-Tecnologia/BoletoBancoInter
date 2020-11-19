using BoletoInter.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoInter
{
    public class ApplicationRegistry
    {

        private IServiceCollection services;

        public ApplicationRegistry(IServiceCollection services)
        {
            this.services = services;
        }

        public void RegisterServices()
        {
            services.AddTransient<BoletoService, BoletoService>();
        }
    }
}
