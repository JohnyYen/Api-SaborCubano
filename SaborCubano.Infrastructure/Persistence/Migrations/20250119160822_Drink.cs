using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SaborCubano.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Drink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plate_CookType_CookTypeId",
                table: "Plate");

            migrationBuilder.DropForeignKey(
                name: "FK_Plate_Ingredient_IngredientId",
                table: "Plate");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantService_Restaurant_Id_Res",
                table: "RestaurantService");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantService_Service_Id_Service",
                table: "RestaurantService");

            migrationBuilder.DropTable(
                name: "AppUserActivity");

            migrationBuilder.DropTable(
                name: "CouponAppUser");

            migrationBuilder.DropTable(
                name: "PlateCookType");

            migrationBuilder.DropTable(
                name: "PlateIngredient");

            migrationBuilder.DropTable(
                name: "RestaurantBussinesType");

            migrationBuilder.DropTable(
                name: "RestaurantFoodTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantService",
                table: "RestaurantService");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantService_Id_Res",
                table: "RestaurantService");

            migrationBuilder.DropIndex(
                name: "IX_Plate_CookTypeId",
                table: "Plate");

            migrationBuilder.DropIndex(
                name: "IX_Plate_IngredientId",
                table: "Plate");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RestaurantService");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "RestaurantService");

            migrationBuilder.DropColumn(
                name: "CookTypeId",
                table: "Plate");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "Plate");

            migrationBuilder.RenameColumn(
                name: "Id_Service",
                table: "RestaurantService",
                newName: "ServicesId");

            migrationBuilder.RenameColumn(
                name: "Id_Res",
                table: "RestaurantService",
                newName: "RestaurantsId");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantService_Id_Service",
                table: "RestaurantService",
                newName: "IX_RestaurantService_ServicesId");

            migrationBuilder.AddColumn<int>(
                name: "Id_Coord",
                table: "Restaurant",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Drink",
                table: "Plate",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantService",
                table: "RestaurantService",
                columns: new[] { "RestaurantsId", "ServicesId" });

            migrationBuilder.CreateTable(
                name: "ActivityAppUser",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(type: "integer", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityAppUser", x => new { x.ActivitiesId, x.AppUserId });
                    table.ForeignKey(
                        name: "FK_ActivityAppUser_Activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityAppUser_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserCoupon",
                columns: table => new
                {
                    AppUsersId = table.Column<string>(type: "text", nullable: false),
                    CouponId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserCoupon", x => new { x.AppUsersId, x.CouponId });
                    table.ForeignKey(
                        name: "FK_AppUserCoupon_AppUser_AppUsersId",
                        column: x => x.AppUsersId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserCoupon_Coupon_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "CookTypePlate",
                columns: table => new
                {
                    CookTypesId = table.Column<int>(type: "integer", nullable: false),
                    PlatesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookTypePlate", x => new { x.CookTypesId, x.PlatesId });
                    table.ForeignKey(
                        name: "FK_CookTypePlate_CookType_CookTypesId",
                        column: x => x.CookTypesId,
                        principalTable: "CookType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CookTypePlate_Plate_PlatesId",
                        column: x => x.PlatesId,
                        principalTable: "Plate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitude = table.Column<float>(type: "real", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false),
                    Id_Res = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "IngredientPlate",
                columns: table => new
                {
                    IngredientsId = table.Column<int>(type: "integer", nullable: false),
                    PlatesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientPlate", x => new { x.IngredientsId, x.PlatesId });
                    table.ForeignKey(
                        name: "FK_IngredientPlate_Ingredient_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientPlate_Plate_PlatesId",
                        column: x => x.PlatesId,
                        principalTable: "Plate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_Id_Coord",
                table: "Restaurant",
                column: "Id_Coord",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAppUser_AppUserId",
                table: "ActivityAppUser",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserCoupon_CouponId",
                table: "AppUserCoupon",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_BussinesTypeRestaurant_RestaurantBussinesTypesId",
                table: "BussinesTypeRestaurant",
                column: "RestaurantBussinesTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_CookTypePlate_PlatesId",
                table: "CookTypePlate",
                column: "PlatesId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodTypeRestaurant_RestaurantsId",
                table: "FoodTypeRestaurant",
                column: "RestaurantsId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientPlate_PlatesId",
                table: "IngredientPlate",
                column: "PlatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_Coordinates_Id_Coord",
                table: "Restaurant",
                column: "Id_Coord",
                principalTable: "Coordinates",
                principalColumn: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_Coordinates_Id_Coord",
                table: "Restaurant");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantService_Restaurant_RestaurantsId",
                table: "RestaurantService");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantService_Service_ServicesId",
                table: "RestaurantService");

            migrationBuilder.DropTable(
                name: "ActivityAppUser");

            migrationBuilder.DropTable(
                name: "AppUserCoupon");

            migrationBuilder.DropTable(
                name: "BussinesTypeRestaurant");

            migrationBuilder.DropTable(
                name: "CookTypePlate");

            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropTable(
                name: "FoodTypeRestaurant");

            migrationBuilder.DropTable(
                name: "IngredientPlate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantService",
                table: "RestaurantService");

            migrationBuilder.DropIndex(
                name: "IX_Restaurant_Id_Coord",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Id_Coord",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Is_Drink",
                table: "Plate");

            migrationBuilder.RenameColumn(
                name: "ServicesId",
                table: "RestaurantService",
                newName: "Id_Service");

            migrationBuilder.RenameColumn(
                name: "RestaurantsId",
                table: "RestaurantService",
                newName: "Id_Res");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantService_ServicesId",
                table: "RestaurantService",
                newName: "IX_RestaurantService_Id_Service");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RestaurantService",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "RestaurantService",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CookTypeId",
                table: "Plate",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "Plate",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantService",
                table: "RestaurantService",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AppUserActivity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_Activity = table.Column<int>(type: "integer", nullable: false),
                    Id_User = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserActivity_Activities_Id_Activity",
                        column: x => x.Id_Activity,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserActivity_AppUser_Id_User",
                        column: x => x.Id_User,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CouponAppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_AppUser = table.Column<string>(type: "text", nullable: false),
                    Id_Coupon = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouponAppUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CouponAppUser_AppUser_Id_AppUser",
                        column: x => x.Id_AppUser,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CouponAppUser_Coupon_Id_Coupon",
                        column: x => x.Id_Coupon,
                        principalTable: "Coupon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlateCookType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_CT = table.Column<int>(type: "integer", nullable: false),
                    Id_Plate = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlateCookType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlateCookType_CookType_Id_CT",
                        column: x => x.Id_CT,
                        principalTable: "CookType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlateCookType_Plate_Id_Plate",
                        column: x => x.Id_Plate,
                        principalTable: "Plate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlateIngredient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_Ingredient = table.Column<int>(type: "integer", nullable: false),
                    Id_Plate = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlateIngredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlateIngredient_Ingredient_Id_Ingredient",
                        column: x => x.Id_Ingredient,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlateIngredient_Plate_Id_Plate",
                        column: x => x.Id_Plate,
                        principalTable: "Plate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantBussinesType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_BS = table.Column<int>(type: "integer", nullable: false),
                    Id_Res = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantBussinesType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantBussinesType_BussinesType_Id_BS",
                        column: x => x.Id_BS,
                        principalTable: "BussinesType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantBussinesType_Restaurant_Id_Res",
                        column: x => x.Id_Res,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantFoodTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_FoodTypes = table.Column<int>(type: "integer", nullable: false),
                    Id_Res = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantFoodTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantFoodTypes_FoodType_Id_FoodTypes",
                        column: x => x.Id_FoodTypes,
                        principalTable: "FoodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantFoodTypes_Restaurant_Id_Res",
                        column: x => x.Id_Res,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantService_Id_Res",
                table: "RestaurantService",
                column: "Id_Res");

            migrationBuilder.CreateIndex(
                name: "IX_Plate_CookTypeId",
                table: "Plate",
                column: "CookTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Plate_IngredientId",
                table: "Plate",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserActivity_Id_Activity",
                table: "AppUserActivity",
                column: "Id_Activity");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserActivity_Id_User",
                table: "AppUserActivity",
                column: "Id_User");

            migrationBuilder.CreateIndex(
                name: "IX_CouponAppUser_Id_AppUser",
                table: "CouponAppUser",
                column: "Id_AppUser");

            migrationBuilder.CreateIndex(
                name: "IX_CouponAppUser_Id_Coupon",
                table: "CouponAppUser",
                column: "Id_Coupon");

            migrationBuilder.CreateIndex(
                name: "IX_PlateCookType_Id_CT",
                table: "PlateCookType",
                column: "Id_CT");

            migrationBuilder.CreateIndex(
                name: "IX_PlateCookType_Id_Plate",
                table: "PlateCookType",
                column: "Id_Plate");

            migrationBuilder.CreateIndex(
                name: "IX_PlateIngredient_Id_Ingredient",
                table: "PlateIngredient",
                column: "Id_Ingredient");

            migrationBuilder.CreateIndex(
                name: "IX_PlateIngredient_Id_Plate",
                table: "PlateIngredient",
                column: "Id_Plate");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantBussinesType_Id_BS",
                table: "RestaurantBussinesType",
                column: "Id_BS");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantBussinesType_Id_Res",
                table: "RestaurantBussinesType",
                column: "Id_Res");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantFoodTypes_Id_FoodTypes",
                table: "RestaurantFoodTypes",
                column: "Id_FoodTypes");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantFoodTypes_Id_Res",
                table: "RestaurantFoodTypes",
                column: "Id_Res");

            migrationBuilder.AddForeignKey(
                name: "FK_Plate_CookType_CookTypeId",
                table: "Plate",
                column: "CookTypeId",
                principalTable: "CookType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Plate_Ingredient_IngredientId",
                table: "Plate",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantService_Restaurant_Id_Res",
                table: "RestaurantService",
                column: "Id_Res",
                principalTable: "Restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantService_Service_Id_Service",
                table: "RestaurantService",
                column: "Id_Service",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
