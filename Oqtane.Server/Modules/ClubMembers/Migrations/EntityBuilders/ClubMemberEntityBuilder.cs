using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using Oqtane.Databases.Interfaces;
using Oqtane.Documentation;
using Oqtane.Interfaces;
using Oqtane.Migrations;
using Oqtane.Migrations.EntityBuilders;

namespace Oqtane.Modules.ClubMembers.Migrations.EntityBuilders
{
    [PrivateApi]
    public class ClubMemberEntityBuilder : AuditableBaseEntityBuilder<ClubMemberEntityBuilder>
    {
        private const string _entityTableName = "ClubMember";
        private readonly PrimaryKey<ClubMemberEntityBuilder> _primaryKey = new("PK_ClubMember", x => x.ClubMemberId);
        private readonly ForeignKey<ClubMemberEntityBuilder> _moduleForeignKey = new("FK_ClubMember_Module", x => x.ModuleId, "Module", "ModuleId", ReferentialAction.Cascade);

        public ClubMemberEntityBuilder(MigrationBuilder migrationBuilder, IDatabase database) : base(migrationBuilder, database)
        {
            EntityTableName = _entityTableName;
            PrimaryKey = _primaryKey;
            ForeignKeys.Add(_moduleForeignKey);
        }

        protected override ClubMemberEntityBuilder BuildTable(ColumnsBuilder table)
        {
            ClubMemberId = AddAutoIncrementColumn(table, "ClubMemberId");
            ModuleId = AddIntegerColumn(table, "ModuleId");

            FirstName = AddMaxStringColumn(table, "FirstName");
            LastName = AddMaxStringColumn(table, "LastName");
            PhotoFileId = AddIntegerColumn(table, "PhotoFileId");

            Ika = AddMaxStringColumn(table, "Ika");
            KuinkaPitkaanHarrastanut = AddMaxStringColumn(table, "KuinkaPitkaanHarrastanut");
            Pelivaineet = AddMaxStringColumn(table, "Pelivaineet");
            MiksiBiljardi = AddMaxStringColumn(table, "MiksiBiljardi");
            LempiLyonti = AddMaxStringColumn(table, "LempiLyonti");
            Idoli = AddMaxStringColumn(table, "Idoli");
            Motto = AddMaxStringColumn(table, "Motto");

            AddAuditableColumns(table);

            return this;
        }

        public OperationBuilder<AddColumnOperation> ClubMemberId { get; set; }
        public OperationBuilder<AddColumnOperation> ModuleId { get; set; }

        public OperationBuilder<AddColumnOperation> FirstName { get; set; }
        public OperationBuilder<AddColumnOperation> LastName { get; set; }
        public OperationBuilder<AddColumnOperation> PhotoFileId { get; set; }

        public OperationBuilder<AddColumnOperation> Ika { get; set; }
        public OperationBuilder<AddColumnOperation> KuinkaPitkaanHarrastanut { get; set; }
        public OperationBuilder<AddColumnOperation> Pelivaineet { get; set; }
        public OperationBuilder<AddColumnOperation> MiksiBiljardi { get; set; }
        public OperationBuilder<AddColumnOperation> LempiLyonti { get; set; }
        public OperationBuilder<AddColumnOperation> Idoli { get; set; }
        public OperationBuilder<AddColumnOperation> Motto { get; set; }
    }
}
