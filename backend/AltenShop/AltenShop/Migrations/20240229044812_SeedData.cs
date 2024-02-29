using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltenShop.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Code", "Description", "Image", "InventoryStatus", "Name", "Price", "Quantity", "Rating" },
                values: new object[,]
                {
                    { 1000, "Accessories", "f230fh0g3", "Product Description", "bamboo-watch.jpg", "INSTOCK", "Bamboo Watch", 65, 24, 5 },
                    { 1001, "Accessories", "nvklal433", "Product Description", "black-watch.jpg", "INSTOCK", "Black Watch", 72, 61, 4 },
                    { 1002, "Fitness", "zz21cz3c1", "Product Description", "blue-band.jpg", "LOWSTOCK", "Blue Band", 79, 2, 3 },
                    { 1003, "Clothing", "244wgerg2", "Product Description", "blue-t-shirt.jpg", "INSTOCK", "Blue T-Shirt", 29, 25, 5 },
                    { 1004, "Accessories", "h456wer53", "Product Description", "bracelet.jpg", "INSTOCK", "Bracelet", 15, 73, 4 },
                    { 1005, "Accessories", "av2231fwg", "Product Description", "brown-purse.jpg", "OUTOFSTOCK", "Brown Purse", 120, 0, 4 },
                    { 1006, "Accessories", "bib36pfvm", "Product Description", "chakra-bracelet.jpg", "LOWSTOCK", "Chakra Bracelet", 32, 5, 3 },
                    { 1007, "Accessories", "mbvjkgip5", "Product Description", "galaxy-earrings.jpg", "INSTOCK", "Galaxy Earrings", 34, 23, 5 },
                    { 1008, "Electronics", "vbb124btr", "Product Description", "game-controller.jpg", "LOWSTOCK", "Game Controller", 99, 2, 4 },
                    { 1009, "Electronics", "cm230f032", "Product Description", "gaming-set.jpg", "INSTOCK", "Gaming Set", 299, 63, 3 },
                    { 1010, "Accessories", "plb34234v", "Product Description", "gold-phone-case.jpg", "OUTOFSTOCK", "Gold Phone Case", 24, 0, 4 },
                    { 1011, "Electronics", "4920nnc2d", "Product Description", "green-earbuds.jpg", "INSTOCK", "Green Earbuds", 89, 23, 4 },
                    { 1012, "Clothing", "250vm23cc", "Product Description", "green-t-shirt.jpg", "INSTOCK", "Green T-Shirt", 49, 74, 5 },
                    { 1013, "Clothing", "fldsmn31b", "Product Description", "grey-t-shirt.jpg", "OUTOFSTOCK", "Grey T-Shirt", 48, 0, 3 },
                    { 1014, "Electronics", "waas1x2as", "Product Description", "headphones.jpg", "LOWSTOCK", "Headphones", 175, 8, 5 },
                    { 1015, "Clothing", "vb34btbg5", "Product Description", "light-green-t-shirt.jpg", "INSTOCK", "Light Green T-Shirt", 49, 34, 4 },
                    { 1016, "Fitness", "k8l6j58jl", "Product Description", "lime-band.jpg", "INSTOCK", "Lime Band", 79, 12, 3 },
                    { 1017, "Clothing", "v435nn85n", "Product Description", "mini-speakers.jpg", "INSTOCK", "Mini Speakers", 85, 42, 4 },
                    { 1018, "Accessories", "09zx9c0zc", "Product Description", "painted-phone-case.jpg", "INSTOCK", "Painted Phone Case", 56, 41, 5 },
                    { 1019, "Fitness", "mnb5mb2m5", "Product Description", "pink-band.jpg", "INSTOCK", "Pink Band", 79, 63, 4 },
                    { 1020, "Accessories", "r23fwf2w3", "Product Description", "pink-purse.jpg", "OUTOFSTOCK", "Pink Purse", 110, 0, 4 },
                    { 1021, "Fitness", "pxpzczo23", "Product Description", "purple-band.jpg", "LOWSTOCK", "Purple Band", 79, 6, 3 },
                    { 1022, "Accessories", "2c42cb5cb", "Product Description", "purple-gemstone-necklace.jpg", "INSTOCK", "Purple Gemstone Necklace", 45, 62, 4 },
                    { 1023, "Clothing", "5k43kkk23", "Product Description", "purple-t-shirt.jpg", "LOWSTOCK", "Purple T-Shirt", 49, 2, 5 },
                    { 1024, "Clothing", "lm2tny2k4", "Product Description", "shoes.jpg", "INSTOCK", "Shoes", 64, 0, 4 },
                    { 1025, "Clothing", "nbm5mv45n", "Product Description", "sneakers.jpg", "INSTOCK", "Sneakers", 78, 52, 4 },
                    { 1026, "Clothing", "zx23zc42c", "Product Description", "teal-t-shirt.jpg", "LOWSTOCK", "Teal T-Shirt", 49, 3, 3 },
                    { 1027, "Electronics", "acvx872gc", "Product Description", "yellow-earbuds.jpg", "INSTOCK", "Yellow Earbuds", 89, 35, 3 },
                    { 1028, "Fitness", "tx125ck42", "Product Description", "yoga-mat.jpg", "INSTOCK", "Yoga Mat", 20, 15, 5 },
                    { 1029, "Fitness", "gwuby345v", "Product Description", "yoga-set.jpg", "INSTOCK", "Yoga Set", 20, 25, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1029);
        }
    }
}
