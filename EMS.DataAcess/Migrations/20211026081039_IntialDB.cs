using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.DataAcess.Migrations
{
    public partial class IntialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventCategories",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EventStatuses",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EventVenues",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventVenues", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Organizers",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserImages",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ImgPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EventDetails",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    OrganizerID = table.Column<Guid>(nullable: false),
                    EventStatusID = table.Column<Guid>(nullable: false),
                    EventVenueID = table.Column<Guid>(nullable: false),
                    EventCategoryID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventDetails_EventCategories_EventCategoryID",
                        column: x => x.EventCategoryID,
                        principalTable: "EventCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDetails_EventStatuses_EventStatusID",
                        column: x => x.EventStatusID,
                        principalTable: "EventStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDetails_EventVenues_EventVenueID",
                        column: x => x.EventVenueID,
                        principalTable: "EventVenues",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDetails_Organizers_OrganizerID",
                        column: x => x.OrganizerID,
                        principalTable: "Organizers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAdmins",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserJobNumber = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    JobID = table.Column<Guid>(nullable: false),
                    ImgPathID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdmins", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserAdmins_UserImages_ImgPathID",
                        column: x => x.ImgPathID,
                        principalTable: "UserImages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAdmins_Jobs_JobID",
                        column: x => x.JobID,
                        principalTable: "Jobs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAttends",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    IsVIP = table.Column<bool>(nullable: false),
                    UniversityID = table.Column<Guid>(nullable: false),
                    UserTypeID = table.Column<Guid>(nullable: false),
                    NationalityID = table.Column<Guid>(nullable: false),
                    GenderID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAttends", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserAttends_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAttends_Nationalities_NationalityID",
                        column: x => x.NationalityID,
                        principalTable: "Nationalities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAttends_Universities_UniversityID",
                        column: x => x.UniversityID,
                        principalTable: "Universities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAttends_UserTypes_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventAttendances",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    LatestUpdate = table.Column<DateTime>(nullable: false),
                    LatestUpdateUserID = table.Column<long>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserAttendID = table.Column<Guid>(nullable: false),
                    EventDetailsID = table.Column<Guid>(nullable: false),
                    ISAttend = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAttendances", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventAttendances_EventDetails_EventDetailsID",
                        column: x => x.EventDetailsID,
                        principalTable: "EventDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventAttendances_UserAttends_UserAttendID",
                        column: x => x.UserAttendID,
                        principalTable: "UserAttends",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventAttendances_EventDetailsID",
                table: "EventAttendances",
                column: "EventDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_EventAttendances_UserAttendID",
                table: "EventAttendances",
                column: "UserAttendID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDetails_EventCategoryID",
                table: "EventDetails",
                column: "EventCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDetails_EventStatusID",
                table: "EventDetails",
                column: "EventStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDetails_EventVenueID",
                table: "EventDetails",
                column: "EventVenueID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDetails_OrganizerID",
                table: "EventDetails",
                column: "OrganizerID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAdmins_ImgPathID",
                table: "UserAdmins",
                column: "ImgPathID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAdmins_JobID",
                table: "UserAdmins",
                column: "JobID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAttends_GenderID",
                table: "UserAttends",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAttends_NationalityID",
                table: "UserAttends",
                column: "NationalityID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAttends_UniversityID",
                table: "UserAttends",
                column: "UniversityID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAttends_UserTypeID",
                table: "UserAttends",
                column: "UserTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventAttendances");

            migrationBuilder.DropTable(
                name: "UserAdmins");

            migrationBuilder.DropTable(
                name: "EventDetails");

            migrationBuilder.DropTable(
                name: "UserAttends");

            migrationBuilder.DropTable(
                name: "UserImages");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "EventCategories");

            migrationBuilder.DropTable(
                name: "EventStatuses");

            migrationBuilder.DropTable(
                name: "EventVenues");

            migrationBuilder.DropTable(
                name: "Organizers");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.DropTable(
                name: "UserTypes");
        }
    }
}
