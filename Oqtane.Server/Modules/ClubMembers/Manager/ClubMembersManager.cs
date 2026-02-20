using Oqtane.Infrastructure;
using Oqtane.Models;
using Oqtane.Modules.ClubMembers.Repository;
using System.Net;
using Oqtane.Enums;
using Oqtane.Repository;
using Oqtane.Shared;
using Oqtane.Migrations.Framework;
using Oqtane.Migrations;
using Oqtane.Documentation;
using System.Linq;
using Oqtane.Interfaces;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace Oqtane.Modules.ClubMembers.Manager
{
    [PrivateApi]
    public class ClubMembersManager : MigratableModuleBase, IInstallable, IPortable, ISearchable
    {
        private readonly IClubMemberRepository _clubMembers;
        private readonly IDBContextDependencies _DBContextDependencies;
        private readonly ISqlRepository _sqlRepository;

        public ClubMembersManager(
            IClubMemberRepository clubMembers,
            IDBContextDependencies DBContextDependencies,
            ISqlRepository sqlRepository)
        {
            _clubMembers = clubMembers;
            _DBContextDependencies = DBContextDependencies;
            _sqlRepository = sqlRepository;
        }

        public string ExportModule(Module module)
        {
            // simple export
            return "";
        }

        public Task<List<SearchContent>> GetSearchContentsAsync(PageModule pageModule, DateTime lastIndexedOn)
        {
            return Task.FromResult(new List<SearchContent>());
        }

        public void ImportModule(Module module, string content, string version)
        {
            // not implemented
        }

        public bool Install(Tenant tenant, string version)
        {
            if (tenant.DBType == Constants.DefaultDBType && version == "1.0.0")
            {
                _sqlRepository.ExecuteNonQuery(tenant, MigrationUtils.BuildInsertScript("ClubMembers.01.00.00.00"));
            }
            return Migrate(new Repository.ClubMembersContext(_DBContextDependencies), tenant, MigrationType.Up);
        }

        public bool Uninstall(Tenant tenant)
        {
            return Migrate(new Repository.ClubMembersContext(_DBContextDependencies), tenant, MigrationType.Down);
        }
    }
}
