using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(nullable: true),
                    AboutTitleEng = table.Column<string>(nullable: true),
                    AboutName = table.Column<string>(nullable: true),
                    AboutNameEng = table.Column<string>(nullable: true),
                    AboutDescription = table.Column<string>(nullable: true),
                    AboutDescriptionEng = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    ValueEng = table.Column<string>(nullable: true),
                    Mission = table.Column<string>(nullable: true),
                    MissionEng = table.Column<string>(nullable: true),
                    Vission = table.Column<string>(nullable: true),
                    VissionEng = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryNameEng = table.Column<string>(nullable: true),
                    CategoryDesc = table.Column<string>(nullable: true),
                    CategoryDescEng = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyNameEng = table.Column<string>(nullable: true),
                    CompanyPhone = table.Column<string>(nullable: true),
                    CompanyPhone2 = table.Column<string>(nullable: true),
                    ComponayMail = table.Column<string>(nullable: true),
                    CompanyAdress = table.Column<string>(nullable: true),
                    CompanyAdressEng = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerNameEng = table.Column<string>(nullable: true),
                    CustomerMail = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Massage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Corporates",
                columns: table => new
                {
                    CorporateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    TitleEng = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    DescEng = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporates", x => x.CorporateId);
                });

            migrationBuilder.CreateTable(
                name: "Galeries",
                columns: table => new
                {
                    GaleryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageTitle = table.Column<string>(nullable: true),
                    PageTitleEng = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galeries", x => x.GaleryId);
                });

            migrationBuilder.CreateTable(
                name: "HomeAbouts",
                columns: table => new
                {
                    HomeAboutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feature = table.Column<string>(nullable: true),
                    FeatureEng = table.Column<string>(nullable: true),
                    Feature2 = table.Column<string>(nullable: true),
                    Feature2Eng = table.Column<string>(nullable: true),
                    FeatureDesc = table.Column<string>(nullable: true),
                    FeatureDescEng = table.Column<string>(nullable: true),
                    FeatureDesc2 = table.Column<string>(nullable: true),
                    FeatureDesc2Eng = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeAbouts", x => x.HomeAboutId);
                });

            migrationBuilder.CreateTable(
                name: "OurServices",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    TitleEng = table.Column<string>(nullable: true),
                    Feature = table.Column<string>(nullable: true),
                    FeatureEng = table.Column<string>(nullable: true),
                    FeatureDesc = table.Column<string>(nullable: true),
                    FeatureDescEng = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    DescEng = table.Column<string>(nullable: true),
                    FlatIcon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurServices", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ProductNameEng = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ProductDescriptionEng = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    MetarialEng = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    SeatAngleEng = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    TotalWeightEng = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    DimensionsEng = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ThumbDescEng = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Referances",
                columns: table => new
                {
                    ReferanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferanceName = table.Column<string>(nullable: true),
                    ReferanceNameEng = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referances", x => x.ReferanceId);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    SliderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgPath = table.Column<string>(nullable: true),
                    ImgPath2 = table.Column<string>(nullable: true),
                    ImgPath3 = table.Column<string>(nullable: true),
                    ImgPath4 = table.Column<string>(nullable: true),
                    ImgPath5 = table.Column<string>(nullable: true),
                    SliderText = table.Column<string>(nullable: true),
                    EnSliderText = table.Column<string>(nullable: true),
                    SliderText2 = table.Column<string>(nullable: true),
                    EnSliderText2 = table.Column<string>(nullable: true),
                    SliderText3 = table.Column<string>(nullable: true),
                    EnSliderText3 = table.Column<string>(nullable: true),
                    SliderText4 = table.Column<string>(nullable: true),
                    EnSliderText4 = table.Column<string>(nullable: true),
                    SliderText5 = table.Column<string>(nullable: true),
                    EnSliderText5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.SliderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Corporates");

            migrationBuilder.DropTable(
                name: "Galeries");

            migrationBuilder.DropTable(
                name: "HomeAbouts");

            migrationBuilder.DropTable(
                name: "OurServices");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Referances");

            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
