using Microsoft.Extensions.DependencyInjection;
using Oqtane.Modules.ClubMembers.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ClubMemberServiceExtensions
    {
        public static IServiceCollection AddClubMemberServices(this IServiceCollection services)
        {
            services.AddScoped<IClubMemberService, ClubMemberService>();
            return services;
        }
    }
}
