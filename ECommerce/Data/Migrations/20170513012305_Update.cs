using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Data.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserID",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "GradeQuantity",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TotalGrade",
                table: "Seller",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserID",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Seller_ApplicationUserID",
                table: "Seller",
                column: "ApplicationUserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ApplicationUserID",
                table: "Customer",
                column: "ApplicationUserID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Seller_ApplicationUserID",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Customer_ApplicationUserID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "GradeQuantity",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "TotalGrade",
                table: "Seller");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserID",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserID",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
