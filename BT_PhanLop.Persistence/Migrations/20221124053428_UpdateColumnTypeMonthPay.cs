using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTPhanLop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnTypeMonthPay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MonthPay",
                table: "PaymentRecords",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MonthPay",
                table: "PaymentRecords",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
