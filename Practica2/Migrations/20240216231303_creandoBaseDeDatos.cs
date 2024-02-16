using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica2.Migrations
{
    /// <inheritdoc />
    public partial class creandoBaseDeDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_categoria",
                columns: table => new
                {
                    idCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ordenes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_categoria", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "tbl_consola",
                columns: table => new
                {
                    idConsola = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_consola", x => x.idConsola);
                });

            migrationBuilder.CreateTable(
                name: "tbl_producto",
                columns: table => new
                {
                    idProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcionCorta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    imagen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idConsola = table.Column<int>(type: "int", nullable: false),
                    idCategoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_producto", x => x.idProducto);
                    table.ForeignKey(
                        name: "FK_tbl_producto_tbl_categoria_idCategoria",
                        column: x => x.idCategoria,
                        principalTable: "tbl_categoria",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_producto_tbl_consola_idConsola",
                        column: x => x.idConsola,
                        principalTable: "tbl_consola",
                        principalColumn: "idConsola",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_producto_idCategoria",
                table: "tbl_producto",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_producto_idConsola",
                table: "tbl_producto",
                column: "idConsola");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_producto");

            migrationBuilder.DropTable(
                name: "tbl_categoria");

            migrationBuilder.DropTable(
                name: "tbl_consola");
        }
    }
}
