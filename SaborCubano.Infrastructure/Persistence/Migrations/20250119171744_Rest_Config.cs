using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaborCubano.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Rest_Config : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantService_Restaurant_RestaurantsId",
                table: "RestaurantService");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantService_Service_ServicesId",
                table: "RestaurantService");

            migrationBuilder.DropTable(
                name: "BussinesTypeRestaurant");

            migrationBuilder.DropTable(
                name: "FoodTypeRestaurant");

            migrationBuilder.RenameColumn(
                name: "ServicesId",
                table: "RestaurantService",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "RestaurantsId",
                table: "RestaurantService",
                newName: "RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantService_ServicesId",
                table: "RestaurantService",
                newName: "IX_RestaurantService_ServiceId");

            migrationBuilder.CreateTable(
                name: "RestaurantBussinesType",
                columns: table => new
                {
                    BussinesTypeId = table.Column<int>(type: "integer", nullable: false),
                    RestaurantId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantBussinesType", x => new { x.BussinesTypeId, x.RestaurantId });
                    table.ForeignKey(
                        name: "FK_RestaurantBussinesType_BussinesType_BussinesTypeId",
                        column: x => x.BussinesTypeId,
                        principalTable: "BussinesType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantBussinesType_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantFoodType",
                columns: table => new
                {
                    FoodTypeId = table.Column<int>(type: "integer", nullable: false),
                    RestaurantId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantFoodType", x => new { x.FoodTypeId, x.RestaurantId });
                    table.ForeignKey(
                        name: "FK_RestaurantFoodType_FoodType_FoodTypeId",
                        column: x => x.FoodTypeId,
                        principalTable: "FoodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantFoodType_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantBussinesType_RestaurantId",
                table: "RestaurantBussinesType",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantFoodType_RestaurantId",
                table: "RestaurantFoodType",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantService_Restaurant_RestaurantId",
                table: "RestaurantService",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantService_Service_ServiceId",
                table: "RestaurantService",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantService_Restaurant_RestaurantId",
                table: "RestaurantService");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantService_Service_ServiceId",
                table: "RestaurantService");

            migrationBuilder.DropTable(
                name: "RestaurantBussinesType");

            migrationBuilder.DropTable(
                name: "RestaurantFoodType");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "RestaurantService",
                newName: "ServicesId");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "RestaurantService",
                newName: "RestaurantsId");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantService_ServiceId",
                table: "RestaurantService",
                newName: "IX_RestaurantService_ServicesId");

            migrationBuilder.CreateTable(
                name: "BussinesTypeRestaurant",
                columns: table => new
                {
                    BussinesTypesId = table.Column<int>(type: "integer", nullable: false),
                    RestaurantBussinesTypesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BussinesTypeRestaurant", x => new { x.BussinesTypesId, x.RestaurantBussinesTypesId });
                    table.ForeignKey(
                        name: "FK_BussinesTypeRestaurant_BussinesType_BussinesTypesId",
                        column: x => x.BussinesTypesId,
                        principalTable: "BussinesType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BussinesTypeRestaurant_Restaurant_RestaurantBussinesTypesId",
                        column: x => x.RestaurantBussinesTypesId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodTypeRestaurant",
                columns: table => new
                {
                    FoodTypesId = table.Column<int>(type: "integer", nullable: false),
                    RestaurantsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodTypeRestaurant", x => new { x.FoodTypesId, x.RestaurantsId });
                    table.ForeignKey(
                        name: "FK_FoodTypeRestaurant_FoodType_FoodTypesId",
                        column: x => x.FoodTypesId,
                        principalTable: "FoodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodTypeRestaurant_Restaurant_RestaurantsId",
                        column: x => x.RestaurantsId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BussinesTypeRestaurant_RestaurantBussinesTypesId",
                table: "BussinesTypeRestaurant",
                column: "RestaurantBussinesTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodTypeRestaurant_RestaurantsId",
                table: "FoodTypeRestaurant",
                column: "RestaurantsId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantService_Restaurant_RestaurantsId",
                table: "RestaurantService",
                column: "RestaurantsId",
                principalTable: "Restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantService_Service_ServicesId",
                table: "RestaurantService",
                column: "ServicesId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
