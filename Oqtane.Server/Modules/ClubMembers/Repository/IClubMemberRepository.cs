using System.Collections.Generic;
using Oqtane.Modules.ClubMembers.Models;

namespace Oqtane.Modules.ClubMembers.Repository
{
    public interface IClubMemberRepository
    {
        IEnumerable<ClubMember> GetClubMembers(int moduleId);
        ClubMember GetClubMember(int clubMemberId);
        ClubMember AddClubMember(ClubMember clubMember);
        ClubMember UpdateClubMember(ClubMember clubMember);
        void DeleteClubMember(int clubMemberId);
    }
}
