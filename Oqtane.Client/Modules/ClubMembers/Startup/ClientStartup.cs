using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Oqtane.Services;
using Oqtane.Modules.ClubMembers.Services;

namespace Oqtane.Modules.ClubMembers.Startup
{
    public class ClientStartup : IClientStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            if (!services.Any(s => s.ServiceType == typeof(IClubMemberService)))
            {
                services.AddScoped<IClubMemberService, ClubMemberService>();
            }
        }
    }
}

