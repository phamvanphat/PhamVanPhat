using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnThucTap.Data.Migrations
{
    public partial class taobang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryBookName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Deleteby = table.Column<int>(type: "int", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameClassRoom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Deleteby = table.Column<int>(type: "int", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameNoti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Deleteby = table.Column<int>(type: "int", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Policy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePolicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionPolicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Deleteby = table.Column<int>(type: "int", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Deleteby = table.Column<int>(type: "int", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Deleteby = table.Column<int>(type: "int", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    QuantityAvailable = table.Column<int>(type: "int", nullable: false),
                    Borrowed = table.Column<int>(type: "int", nullable: false),
                    slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCategpryBook = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Deleteby = table.Column<int>(type: "int", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_CategoryBook_IdCategpryBook",
                        column: x => x.IdCategpryBook,
                        principalTable: "CategoryBook",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoke",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStudent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdClassRoom = table.Column<int>(type: "int", nullable: false),
                    AmountBook = table.Column<int>(type: "int", nullable: false),
                    borrowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GiveBackDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Numberphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    classRoomId = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Deleteby = table.Column<int>(type: "int", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoke", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoke_ClassRoom_classRoomId",
                        column: x => x.classRoomId,
                        principalTable: "ClassRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pathImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdBook = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Deleteby = table.Column<int>(type: "int", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageBook_Book_IdBook",
                        column: x => x.IdBook,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvokeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IdInvoke = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Deleteby = table.Column<int>(type: "int", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvokeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvokeDetails_Invoke_IdInvoke",
                        column: x => x.IdInvoke,
                        principalTable: "Invoke",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_IdCategpryBook",
                table: "Book",
                column: "IdCategpryBook");

            migrationBuilder.CreateIndex(
                name: "IX_ImageBook_IdBook",
                table: "ImageBook",
                column: "IdBook");

            migrationBuilder.CreateIndex(
                name: "IX_Invoke_classRoomId",
                table: "Invoke",
                column: "classRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_InvokeDetails_IdInvoke",
                table: "InvokeDetails",
                column: "IdInvoke");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageBook");

            migrationBuilder.DropTable(
                name: "InvokeDetails");

            migrationBuilder.DropTable(
                name: "Notication");

            migrationBuilder.DropTable(
                name: "Policy");

            migrationBuilder.DropTable(
                name: "Rule");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Invoke");

            migrationBuilder.DropTable(
                name: "CategoryBook");

            migrationBuilder.DropTable(
                name: "ClassRoom");
        }
    }
}
