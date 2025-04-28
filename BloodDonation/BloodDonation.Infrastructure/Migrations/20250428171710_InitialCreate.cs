using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodDonation.Infrastructure.Migrations;

/// <inheritdoc />
public partial class InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Cities",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Province = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Cities", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Hospitals",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Province = table.Column<int>(type: "int", nullable: false),
                CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Hospitals", x => x.Id);
                table.ForeignKey(
                    name: "FK_Hospitals_Cities_CityId",
                    column: x => x.CityId,
                    principalTable: "Cities",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Persons",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Cnic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                Age = table.Column<int>(type: "int", nullable: false),
                Otp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Role = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Persons", x => x.Id);
                table.ForeignKey(
                    name: "FK_Persons_Cities_CityId",
                    column: x => x.CityId,
                    principalTable: "Cities",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "BloodRecords",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                BloodGroup = table.Column<int>(type: "int", nullable: false),
                AmountInMilliliters = table.Column<int>(type: "int", nullable: false),
                ActionType = table.Column<int>(type: "int", nullable: false),
                ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                DonationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_BloodRecords", x => x.Id);
                table.ForeignKey(
                    name: "FK_BloodRecords_Persons_PersonId",
                    column: x => x.PersonId,
                    principalTable: "Persons",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "BloodTests",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                TestType = table.Column<int>(type: "int", nullable: false),
                TestOutcome = table.Column<int>(type: "int", nullable: false),
                Eligible = table.Column<bool>(type: "bit", nullable: false),
                TestDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_BloodTests", x => x.Id);
                table.ForeignKey(
                    name: "FK_BloodTests_Persons_PersonId",
                    column: x => x.PersonId,
                    principalTable: "Persons",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_BloodRecords_PersonId",
            table: "BloodRecords",
            column: "PersonId");

        migrationBuilder.CreateIndex(
            name: "IX_BloodTests_PersonId",
            table: "BloodTests",
            column: "PersonId");

        migrationBuilder.CreateIndex(
            name: "IX_Hospitals_CityId",
            table: "Hospitals",
            column: "CityId");

        migrationBuilder.CreateIndex(
            name: "IX_Persons_CityId",
            table: "Persons",
            column: "CityId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "BloodRecords");

        migrationBuilder.DropTable(
            name: "BloodTests");

        migrationBuilder.DropTable(
            name: "Hospitals");

        migrationBuilder.DropTable(
            name: "Persons");

        migrationBuilder.DropTable(
            name: "Cities");
    }
}
