using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class renamingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episode_Author_AuthorId",
                table: "Episode");

            migrationBuilder.DropForeignKey(
                name: "FK_Episode_Doctor_DoctorId",
                table: "Episode");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanion_Companion_CompanionId",
                table: "EpisodeCompanion");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanion_Episode_EpisodeId",
                table: "EpisodeCompanion");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemy_Enemy_EnemyId",
                table: "EpisodeEnemy");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemy_Episode_EpisodeId",
                table: "EpisodeEnemy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EpisodeEnemy",
                table: "EpisodeEnemy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EpisodeCompanion",
                table: "EpisodeCompanion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Episode",
                table: "Episode");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Episode_EpisodeType_Enum",
                table: "Episode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enemy",
                table: "Enemy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companion",
                table: "Companion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "EpisodeEnemy",
                newName: "tblEpisodeEnemy");

            migrationBuilder.RenameTable(
                name: "EpisodeCompanion",
                newName: "tblEpisodeCompanion");

            migrationBuilder.RenameTable(
                name: "Episode",
                newName: "tblEpisode");

            migrationBuilder.RenameTable(
                name: "Enemy",
                newName: "tblEnemy");

            migrationBuilder.RenameTable(
                name: "Doctor",
                newName: "tblDoctor");

            migrationBuilder.RenameTable(
                name: "Companion",
                newName: "tblCompanion");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "tblAuthor");

            migrationBuilder.RenameIndex(
                name: "IX_EpisodeEnemy_EnemyId",
                table: "tblEpisodeEnemy",
                newName: "IX_tblEpisodeEnemy_EnemyId");

            migrationBuilder.RenameIndex(
                name: "IX_EpisodeCompanion_CompanionId",
                table: "tblEpisodeCompanion",
                newName: "IX_tblEpisodeCompanion_CompanionId");

            migrationBuilder.RenameIndex(
                name: "IX_Episode_DoctorId",
                table: "tblEpisode",
                newName: "IX_tblEpisode_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Episode_AuthorId",
                table: "tblEpisode",
                newName: "IX_tblEpisode_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblEpisodeEnemy",
                table: "tblEpisodeEnemy",
                columns: new[] { "EpisodeId", "EnemyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblEpisodeCompanion",
                table: "tblEpisodeCompanion",
                columns: new[] { "EpisodeId", "CompanionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblEpisode",
                table: "tblEpisode",
                column: "EpisodeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblEnemy",
                table: "tblEnemy",
                column: "EnemyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblDoctor",
                table: "tblDoctor",
                column: "DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblCompanion",
                table: "tblCompanion",
                column: "CompanionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblAuthor",
                table: "tblAuthor",
                column: "AuthorId");

            migrationBuilder.AddCheckConstraint(
                name: "CK_tblEpisode_EpisodeType_Enum",
                table: "tblEpisode",
                sql: "[EpisodeType] IN (N'Trailer', N'Bonus', N'Full')");

            migrationBuilder.AddForeignKey(
                name: "FK_tblEpisode_tblAuthor_AuthorId",
                table: "tblEpisode",
                column: "AuthorId",
                principalTable: "tblAuthor",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblEpisode_tblDoctor_DoctorId",
                table: "tblEpisode",
                column: "DoctorId",
                principalTable: "tblDoctor",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblEpisodeCompanion_tblCompanion_CompanionId",
                table: "tblEpisodeCompanion",
                column: "CompanionId",
                principalTable: "tblCompanion",
                principalColumn: "CompanionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblEpisodeCompanion_tblEpisode_EpisodeId",
                table: "tblEpisodeCompanion",
                column: "EpisodeId",
                principalTable: "tblEpisode",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblEpisodeEnemy_tblEnemy_EnemyId",
                table: "tblEpisodeEnemy",
                column: "EnemyId",
                principalTable: "tblEnemy",
                principalColumn: "EnemyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblEpisodeEnemy_tblEpisode_EpisodeId",
                table: "tblEpisodeEnemy",
                column: "EpisodeId",
                principalTable: "tblEpisode",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblEpisode_tblAuthor_AuthorId",
                table: "tblEpisode");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEpisode_tblDoctor_DoctorId",
                table: "tblEpisode");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEpisodeCompanion_tblCompanion_CompanionId",
                table: "tblEpisodeCompanion");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEpisodeCompanion_tblEpisode_EpisodeId",
                table: "tblEpisodeCompanion");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEpisodeEnemy_tblEnemy_EnemyId",
                table: "tblEpisodeEnemy");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEpisodeEnemy_tblEpisode_EpisodeId",
                table: "tblEpisodeEnemy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblEpisodeEnemy",
                table: "tblEpisodeEnemy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblEpisodeCompanion",
                table: "tblEpisodeCompanion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblEpisode",
                table: "tblEpisode");

            migrationBuilder.DropCheckConstraint(
                name: "CK_tblEpisode_EpisodeType_Enum",
                table: "tblEpisode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblEnemy",
                table: "tblEnemy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblDoctor",
                table: "tblDoctor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblCompanion",
                table: "tblCompanion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblAuthor",
                table: "tblAuthor");

            migrationBuilder.RenameTable(
                name: "tblEpisodeEnemy",
                newName: "EpisodeEnemy");

            migrationBuilder.RenameTable(
                name: "tblEpisodeCompanion",
                newName: "EpisodeCompanion");

            migrationBuilder.RenameTable(
                name: "tblEpisode",
                newName: "Episode");

            migrationBuilder.RenameTable(
                name: "tblEnemy",
                newName: "Enemy");

            migrationBuilder.RenameTable(
                name: "tblDoctor",
                newName: "Doctor");

            migrationBuilder.RenameTable(
                name: "tblCompanion",
                newName: "Companion");

            migrationBuilder.RenameTable(
                name: "tblAuthor",
                newName: "Author");

            migrationBuilder.RenameIndex(
                name: "IX_tblEpisodeEnemy_EnemyId",
                table: "EpisodeEnemy",
                newName: "IX_EpisodeEnemy_EnemyId");

            migrationBuilder.RenameIndex(
                name: "IX_tblEpisodeCompanion_CompanionId",
                table: "EpisodeCompanion",
                newName: "IX_EpisodeCompanion_CompanionId");

            migrationBuilder.RenameIndex(
                name: "IX_tblEpisode_DoctorId",
                table: "Episode",
                newName: "IX_Episode_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_tblEpisode_AuthorId",
                table: "Episode",
                newName: "IX_Episode_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EpisodeEnemy",
                table: "EpisodeEnemy",
                columns: new[] { "EpisodeId", "EnemyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EpisodeCompanion",
                table: "EpisodeCompanion",
                columns: new[] { "EpisodeId", "CompanionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Episode",
                table: "Episode",
                column: "EpisodeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enemy",
                table: "Enemy",
                column: "EnemyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companion",
                table: "Companion",
                column: "CompanionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "AuthorId");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Episode_EpisodeType_Enum",
                table: "Episode",
                sql: "[EpisodeType] IN (N'Trailer', N'Bonus', N'Full')");

            migrationBuilder.AddForeignKey(
                name: "FK_Episode_Author_AuthorId",
                table: "Episode",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episode_Doctor_DoctorId",
                table: "Episode",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanion_Companion_CompanionId",
                table: "EpisodeCompanion",
                column: "CompanionId",
                principalTable: "Companion",
                principalColumn: "CompanionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanion_Episode_EpisodeId",
                table: "EpisodeCompanion",
                column: "EpisodeId",
                principalTable: "Episode",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemy_Enemy_EnemyId",
                table: "EpisodeEnemy",
                column: "EnemyId",
                principalTable: "Enemy",
                principalColumn: "EnemyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemy_Episode_EpisodeId",
                table: "EpisodeEnemy",
                column: "EpisodeId",
                principalTable: "Episode",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
