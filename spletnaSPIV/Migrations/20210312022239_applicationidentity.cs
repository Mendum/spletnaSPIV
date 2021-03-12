using Microsoft.EntityFrameworkCore.Migrations;

namespace spletnaSPIV.Migrations
{
    public partial class applicationidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Wallets_RecieverId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Wallets_SenderId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_AspNetUsers_UserId",
                table: "Wallets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wallets",
                table: "Wallets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Wallets",
                newName: "wallet");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "transaction");

            migrationBuilder.RenameIndex(
                name: "IX_Wallets_UserId",
                table: "wallet",
                newName: "IX_wallet_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_SenderId",
                table: "transaction",
                newName: "IX_transaction_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_RecieverId",
                table: "transaction",
                newName: "IX_transaction_RecieverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_wallet",
                table: "wallet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_transaction",
                table: "transaction",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_wallet_RecieverId",
                table: "transaction",
                column: "RecieverId",
                principalTable: "wallet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_wallet_SenderId",
                table: "transaction",
                column: "SenderId",
                principalTable: "wallet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wallet_user_UserId",
                table: "wallet",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transaction_wallet_RecieverId",
                table: "transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_wallet_SenderId",
                table: "transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_wallet_user_UserId",
                table: "wallet");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_wallet",
                table: "wallet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_transaction",
                table: "transaction");

            migrationBuilder.RenameTable(
                name: "wallet",
                newName: "Wallets");

            migrationBuilder.RenameTable(
                name: "transaction",
                newName: "Transactions");

            migrationBuilder.RenameIndex(
                name: "IX_wallet_UserId",
                table: "Wallets",
                newName: "IX_Wallets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_transaction_SenderId",
                table: "Transactions",
                newName: "IX_Transactions_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_transaction_RecieverId",
                table: "Transactions",
                newName: "IX_Transactions_RecieverId");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wallets",
                table: "Wallets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Wallets_RecieverId",
                table: "Transactions",
                column: "RecieverId",
                principalTable: "Wallets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Wallets_SenderId",
                table: "Transactions",
                column: "SenderId",
                principalTable: "Wallets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_AspNetUsers_UserId",
                table: "Wallets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
