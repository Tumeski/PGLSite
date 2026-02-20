using System.Collections.Generic;
using System.Threading.Tasks;
using Oqtane.Modules.ClubMembers.Models;

namespace Oqtane.Modules.ClubMembers.Services
{
    public interface IClubMemberService
    {
        Task<List<ClubMember>> GetClubMembersAsync(int moduleId);
        Task<ClubMember> GetClubMemberAsync(int clubMemberId);
        Task<ClubMember> AddClubMemberAsync(ClubMember clubMember);
        Task<ClubMember> UpdateClubMemberAsync(ClubMember clubMember);
        Task DeleteClubMemberAsync(int clubMemberId);
    }
}
