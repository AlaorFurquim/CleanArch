using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArch.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" + 
                "VALUES('Caderno Hulk','Caderno Hulk 250 Folhas',25.25,100,'caderno.jpg',1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}
