using Microsoft.EntityFrameworkCore;
using Oqtane.Documentation;
using Oqtane.Repository;
using Oqtane.Repository.Databases.Interfaces;

namespace Oqtane.Modules.ClubMembers.Repository
{
    [PrivateApi]
    public class ClubMembersContext : DBContextBase, ITransientService, IMultiDatabase
    {
        public ClubMembersContext(IDBContextDependencies DBContextDependencies) : base(DBContextDependencies) { }

        public virtual DbSet<Oqtane.Modules.ClubMembers.Models.ClubMember> ClubMember { get; set; }
    }
}
