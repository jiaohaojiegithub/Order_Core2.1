using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Order_Core2.Migrations
{
    public partial class AddUser_LoginTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User_Login",
                columns: table => new
                {
                    User_Login_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User_Login_Name = table.Column<string>(maxLength: 20, nullable: true),
                    User_Login_EmailAddress = table.Column<string>(type: "varchar(200)", nullable: true),
                    User_Login_PassWord = table.Column<string>(maxLength: 20, nullable: true),
                    User_Login_Sex = table.Column<string>(maxLength: 5, nullable: true),
                    User_Login_Right = table.Column<int>(nullable: false),
                    User_Login_State = table.Column<bool>(nullable: false),
                    User_Login_Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    User_Login_CreatDT = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Login", x => x.User_Login_ID);
                });

            migrationBuilder.InsertData(
                table: "User_Login",
                columns: new[] { "User_Login_ID", "User_Login_CreatDT", "User_Login_EmailAddress", "User_Login_Guid", "User_Login_Name", "User_Login_PassWord", "User_Login_Right", "User_Login_Sex", "User_Login_State" },
                values: new object[] { 1, new DateTime(2018, 7, 15, 23, 11, 34, 10, DateTimeKind.Local), "2351592225@qq.com", new Guid("6c8d25ff-0a0e-4377-9f99-4737e1784d27"), "Administrator", "Administrator", 0, "男", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User_Login");
        }
    }
}
