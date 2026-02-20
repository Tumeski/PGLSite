using System.Linq;
using Oqtane.Modules.ClubMembers.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Oqtane.Modules;

namespace Oqtane.Modules.ClubMembers.Repository
{
    public class ClubMemberRepository : IClubMemberRepository, ITransientService
    {
        private readonly IDbContextFactory<ClubMembersContext> _factory;

        public ClubMemberRepository(IDbContextFactory<ClubMembersContext> factory)
        {
            _factory = factory;
        }

        public IEnumerable<ClubMember> GetClubMembers(int moduleId)
        {
            using var db = _factory.CreateDbContext();
            return db.ClubMember.Where(item => item.ModuleId == moduleId).ToList();
        }

        public ClubMember GetClubMember(int clubMemberId)
        {
            using var db = _factory.CreateDbContext();
            return db.ClubMember.Find(clubMemberId);
        }

        public ClubMember AddClubMember(ClubMember clubMember)
        {
            using var db = _factory.CreateDbContext();
            db.ClubMember.Add(clubMember);
            db.SaveChanges();
            return clubMember;
        }

        public ClubMember UpdateClubMember(ClubMember clubMember)
        {
            using var db = _factory.CreateDbContext();
            db.ClubMember.Update(clubMember);
            db.SaveChanges();
            return clubMember;
        }

        public void DeleteClubMember(int clubMemberId)
        {
            using var db = _factory.CreateDbContext();
            var clubMember = db.ClubMember.FirstOrDefault(item => item.ClubMemberId == clubMemberId);
            if (clubMember != null) db.ClubMember.Remove(clubMember);
            db.SaveChanges();
        }
    }
}
