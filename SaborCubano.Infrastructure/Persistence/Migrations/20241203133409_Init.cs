using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SaborCubano.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Score = table.Column<double>(type: "double precision", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BussinesType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BussinesType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CookType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    User_Name = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    User_Type = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    Gallery = table.Column<byte[][]>(type: "bytea[]", nullable: true),
                    AppUserId = table.Column<int>(type: "integer", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_User_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_Prov = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Province_Id_Prov",
                        column: x => x.Id_Prov,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserActivity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_User = table.Column<int>(type: "integer", nullable: false),
                    Id_Activity = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_AppUserActivity_User_Id_User",
                        column: x => x.Id_User,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_City = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Direction = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Cont_Num = table.Column<string>(type: "text", nullable: true),
                    Email_Res = table.Column<string>(type: "text", nullable: true),
                    Open_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Close_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Have_Home = table.Column<bool>(type: "boolean", nullable: true),
                    Is_Reservas = table.Column<bool>(type: "boolean", nullable: true),
                    Id_User = table.Column<int>(type: "integer", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurant_City_Id_City",
                        column: x => x.Id_City,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restaurant_User_Id_User",
                        column: x => x.Id_User,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Coupon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_User = table.Column<int>(type: "integer", nullable: false),
                    Id_Res = table.Column<int>(type: "integer", nullable: false),
                    Discount = table.Column<int>(type: "integer", nullable: false),
                    Expire_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coupon_Restaurant_Id_Res",
                        column: x => x.Id_Res,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_Res = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Calories = table.Column<float>(type: "real", nullable: false),
                    CookTypeId = table.Column<int>(type: "integer", nullable: true),
                    IngredientId = table.Column<int>(type: "integer", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plate_CookType_CookTypeId",
                        column: x => x.CookTypeId,
                        principalTable: "CookType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Plate_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Plate_Restaurant_Id_Res",
                        column: x => x.Id_Res,
                        principalTable: "Restaurant",
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
                    Id_Res = table.Column<int>(type: "integer", nullable: false),
                    Id_FoodTypes = table.Column<int>(type: "integer", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "RestaurantService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_Res = table.Column<int>(type: "integer", nullable: false),
                    Id_Service = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantService_Restaurant_Id_Res",
                        column: x => x.Id_Res,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantService_Service_Id_Service",
                        column: x => x.Id_Service,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CouponAppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_Coupon = table.Column<int>(type: "integer", nullable: false),
                    Id_AppUser = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouponAppUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CouponAppUser_Coupon_Id_Coupon",
                        column: x => x.Id_Coupon,
                        principalTable: "Coupon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CouponAppUser_User_Id_AppUser",
                        column: x => x.Id_AppUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlateCookType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_Plate = table.Column<int>(type: "integer", nullable: false),
                    Id_CT = table.Column<int>(type: "integer", nullable: false),
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
                    Id_Plate = table.Column<int>(type: "integer", nullable: false),
                    Id_Ingredient = table.Column<int>(type: "integer", nullable: false),
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
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Opinion = table.Column<string>(type: "character varying(240)", maxLength: 240, nullable: false),
                    Photos = table.Column<byte[][]>(type: "bytea[]", nullable: true),
                    DateWriting = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Is_Util = table.Column<bool>(type: "boolean", nullable: false),
                    Is_Funny = table.Column<bool>(type: "boolean", nullable: false),
                    Review_Type = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    Valoration_Plate = table.Column<int>(type: "integer", nullable: true),
                    Eat_In_Local = table.Column<bool>(type: "boolean", nullable: true),
                    Id_Plate = table.Column<int>(type: "integer", nullable: true),
                    Valoration_Local = table.Column<int>(type: "integer", nullable: true),
                    Valoration_Service = table.Column<int>(type: "integer", nullable: true),
                    Valoration_Price = table.Column<int>(type: "integer", nullable: true),
                    Valoration_Higiene = table.Column<int>(type: "integer", nullable: true),
                    Id_Res = table.Column<int>(type: "integer", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Plate_Id_Plate",
                        column: x => x.Id_Plate,
                        principalTable: "Plate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_Restaurant_Id_Res",
                        column: x => x.Id_Res,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserActivity_Id_Activity",
                table: "AppUserActivity",
                column: "Id_Activity");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserActivity_Id_User",
                table: "AppUserActivity",
                column: "Id_User");

            migrationBuilder.CreateIndex(
                name: "IX_City_Id_Prov",
                table: "City",
                column: "Id_Prov");

            migrationBuilder.CreateIndex(
                name: "IX_Coupon_Id_Res",
                table: "Coupon",
                column: "Id_Res");

            migrationBuilder.CreateIndex(
                name: "IX_CouponAppUser_Id_AppUser",
                table: "CouponAppUser",
                column: "Id_AppUser");

            migrationBuilder.CreateIndex(
                name: "IX_CouponAppUser_Id_Coupon",
                table: "CouponAppUser",
                column: "Id_Coupon");

            migrationBuilder.CreateIndex(
                name: "IX_Plate_CookTypeId",
                table: "Plate",
                column: "CookTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Plate_Id_Res",
                table: "Plate",
                column: "Id_Res");

            migrationBuilder.CreateIndex(
                name: "IX_Plate_IngredientId",
                table: "Plate",
                column: "IngredientId");

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
                name: "IX_Restaurant_Id_City",
                table: "Restaurant",
                column: "Id_City");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_Id_User",
                table: "Restaurant",
                column: "Id_User");

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

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantService_Id_Res",
                table: "RestaurantService",
                column: "Id_Res");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantService_Id_Service",
                table: "RestaurantService",
                column: "Id_Service");

            migrationBuilder.CreateIndex(
                name: "IX_Review_Id_Plate",
                table: "Review",
                column: "Id_Plate");

            migrationBuilder.CreateIndex(
                name: "IX_Review_Id_Res",
                table: "Review",
                column: "Id_Res");

            migrationBuilder.CreateIndex(
                name: "IX_User_AppUserId",
                table: "User",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropTable(
                name: "RestaurantService");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Coupon");

            migrationBuilder.DropTable(
                name: "BussinesType");

            migrationBuilder.DropTable(
                name: "FoodType");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Plate");

            migrationBuilder.DropTable(
                name: "CookType");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
