using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MDRService.WebAPI.Configuration
{
    public interface IServiceInstaller
    {
        void Install(IServiceCollection services, IConfiguration configuration);
    }
}
