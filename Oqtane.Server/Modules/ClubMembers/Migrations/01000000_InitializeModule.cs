using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Oqtane.Databases.Interfaces;
using Oqtane.Documentation;
using Oqtane.Migrations;
using Oqtane.Modules.ClubMembers.Migrations.EntityBuilders;
using Oqtane.Modules.ClubMembers.Repository;

namespace Oqtane.Modules.ClubMembers.Migrations
{
    [DbContext(typeof(ClubMembersContext))]
    [Migration("ClubMembers.01.00.00.00")]
    [PrivateApi]
    public class InitializeModule : MultiDatabaseMigration
    {
        public InitializeModule(IDatabase database) : base(database)
        {
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var entityBuilder = new ClubMemberEntityBuilder(migrationBuilder, ActiveDatabase);
            entityBuilder.Create();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var entityBuilder = new ClubMemberEntityBuilder(migrationBuilder, ActiveDatabase);
            entityBuilder.Drop();
        }
    }
}
