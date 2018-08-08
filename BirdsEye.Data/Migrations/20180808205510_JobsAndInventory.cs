using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdsEye.Data.Migrations
{
    public partial class JobsAndInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    JobUserId = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<string>(nullable: true),
                    DueDate = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemCatagory = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    JobId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventory_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventory_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobUser",
                columns: table => new
                {
                    JobId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobUser", x => new { x.JobId, x.UserId });
                    table.ForeignKey(
                        name: "FK_JobUser_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkNote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthorId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    JobId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkNote_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItemStatus",
                columns: table => new
                {
                    InventoryId = table.Column<int>(nullable: false),
                    ItemStatusId = table.Column<int>(nullable: false),
                    InventoryStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItemStatus", x => new { x.InventoryId, x.ItemStatusId });
                    table.ForeignKey(
                        name: "FK_InventoryItemStatus_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryItemStatus_ItemStatus_InventoryStatusId",
                        column: x => x.InventoryStatusId,
                        principalTable: "ItemStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemNote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    InventoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemNote_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_JobId",
                table: "Inventory",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_UserId",
                table: "Inventory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItemStatus_InventoryStatusId",
                table: "InventoryItemStatus",
                column: "InventoryStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemNote_InventoryId",
                table: "ItemNote",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobUser_UserId",
                table: "JobUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkNote_JobId",
                table: "WorkNote",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryItemStatus");

            migrationBuilder.DropTable(
                name: "ItemNote");

            migrationBuilder.DropTable(
                name: "JobUser");

            migrationBuilder.DropTable(
                name: "WorkNote");

            migrationBuilder.DropTable(
                name: "ItemStatus");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Job");
        }
    }
}
