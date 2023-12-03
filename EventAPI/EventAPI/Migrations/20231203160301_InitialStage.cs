using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventAPI.Migrations
{
    public partial class InitialStage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EventLogo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryNum = table.Column<byte>(type: "tinyint", nullable: false),
                    LikedCount = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "EventLikes",
                columns: table => new
                {
                    LikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLikes", x => x.LikeId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ProfilePicture = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "EventComments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventComments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_EventComments_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "CategoryNum", "CreateOn", "EndDate", "EventLogo", "EventName", "LikedCount", "Location", "StartDate", "UpdateOn", "UserId" },
                values: new object[,]
                {
                    { 1, (byte)15, new DateTime(2023, 12, 3, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(101), new DateTime(2023, 12, 4, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(98), null, "Sea Game 2023", 0, "Location One", new DateTime(2023, 12, 3, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(90), null, 1 },
                    { 2, (byte)5, new DateTime(2023, 12, 3, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(108), new DateTime(2023, 12, 5, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(107), null, "Code C", 0, "Location Two", new DateTime(2023, 12, 3, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(106), null, 2 }
                });

            migrationBuilder.InsertData(
                table: "EventLikes",
                columns: new[] { "LikeId", "EventId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Address", "Name", "Password", "PhoneNumber", "ProfilePicture", "Username" },
                values: new object[,]
                {
                    { 1, null, null, "123456789", null, null, "admin" },
                    { 2, null, "Kim Bo", "password", null, null, "kimbo" }
                });

            migrationBuilder.InsertData(
                table: "EventComments",
                columns: new[] { "CommentId", "EventId", "Text", "UserId" },
                values: new object[] { 1, 1, "Nice Game", 2 });

            migrationBuilder.InsertData(
                table: "EventComments",
                columns: new[] { "CommentId", "EventId", "Text", "UserId" },
                values: new object[] { 2, 2, "Like this event in Cambodia", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_EventComments_EventId",
                table: "EventComments",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventComments");

            migrationBuilder.DropTable(
                name: "EventLikes");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Event");
        }
    }
}
