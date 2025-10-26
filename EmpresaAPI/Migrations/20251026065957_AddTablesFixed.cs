using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usuario_Creacion_Id = table.Column<int>(type: "int", nullable: true),
                    Usuario_Modificacion_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Presupuesto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Fecha_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usuario_Creacion_Id = table.Column<int>(type: "int", nullable: true),
                    Usuario_Modificacion_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Venta_Id = table.Column<int>(type: "int", nullable: false),
                    VentaId = table.Column<int>(type: "int", nullable: false),
                    Producto_Id = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    Fecha_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usuario_Creacion_Id = table.Column<int>(type: "int", nullable: true),
                    Usuario_Modificacion_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVentas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CUI = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Fecha_Ingreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salario_Actual = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Fecha_Ultimo_Aumento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_baja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Puesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jerarquia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Departamento_Id = table.Column<int>(type: "int", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    Fecha_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usuario_Creacion_Id = table.Column<int>(type: "int", nullable: true),
                    Usuario_Modificacion_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistorialSalarials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salario_Anterior = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Salario_nuevo = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Fecha_Cambio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Empleado_Id = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    Fecha_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usuario_Creacion_Id = table.Column<int>(type: "int", nullable: true),
                    Usuario_Modificacion_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialSalarials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialSalarials_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Existencia = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Fecha_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usuario_Creacion_Id = table.Column<int>(type: "int", nullable: true),
                    Usuario_Modificacion_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Rol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Fecha_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usuario_Creacion_Id = table.Column<int>(type: "int", nullable: true),
                    Usuario_Modificacion_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Empleado_Id = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    Rol_Id = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    Fecha_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usuario_Creacion_Id = table.Column<int>(type: "int", nullable: true),
                    Usuario_Modificacion_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Rols_RolId",
                        column: x => x.RolId,
                        principalTable: "Rols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Usuarios_Usuario_Creacion_Id",
                        column: x => x.Usuario_Creacion_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Usuarios_Usuario_Modificacion_Id",
                        column: x => x.Usuario_Modificacion_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Venta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Cliente_Id = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Fecha_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usuario_Creacion_Id = table.Column<int>(type: "int", nullable: true),
                    Usuario_Modificacion_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Usuarios_Usuario_Creacion_Id",
                        column: x => x.Usuario_Creacion_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_Usuarios_Usuario_Modificacion_Id",
                        column: x => x.Usuario_Modificacion_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Usuario_Creacion_Id",
                table: "Clientes",
                column: "Usuario_Creacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Usuario_Modificacion_Id",
                table: "Clientes",
                column: "Usuario_Modificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_Usuario_Creacion_Id",
                table: "Departamentos",
                column: "Usuario_Creacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_Usuario_Modificacion_Id",
                table: "Departamentos",
                column: "Usuario_Modificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_ProductoId",
                table: "DetalleVentas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_Usuario_Creacion_Id",
                table: "DetalleVentas",
                column: "Usuario_Creacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_Usuario_Modificacion_Id",
                table: "DetalleVentas",
                column: "Usuario_Modificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_VentaId",
                table: "DetalleVentas",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DepartamentoId",
                table: "Empleados",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Usuario_Creacion_Id",
                table: "Empleados",
                column: "Usuario_Creacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Usuario_Modificacion_Id",
                table: "Empleados",
                column: "Usuario_Modificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialSalarials_EmpleadoId",
                table: "HistorialSalarials",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialSalarials_Usuario_Creacion_Id",
                table: "HistorialSalarials",
                column: "Usuario_Creacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialSalarials_Usuario_Modificacion_Id",
                table: "HistorialSalarials",
                column: "Usuario_Modificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Usuario_Creacion_Id",
                table: "Productos",
                column: "Usuario_Creacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Usuario_Modificacion_Id",
                table: "Productos",
                column: "Usuario_Modificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rols_Usuario_Creacion_Id",
                table: "Rols",
                column: "Usuario_Creacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rols_Usuario_Modificacion_Id",
                table: "Rols",
                column: "Usuario_Modificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EmpleadoId",
                table: "Usuarios",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Usuario_Creacion_Id",
                table: "Usuarios",
                column: "Usuario_Creacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Usuario_Modificacion_Id",
                table: "Usuarios",
                column: "Usuario_Modificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_Usuario_Creacion_Id",
                table: "Ventas",
                column: "Usuario_Creacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_Usuario_Modificacion_Id",
                table: "Ventas",
                column: "Usuario_Modificacion_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Usuarios_Usuario_Creacion_Id",
                table: "Clientes",
                column: "Usuario_Creacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Usuarios_Usuario_Modificacion_Id",
                table: "Clientes",
                column: "Usuario_Modificacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Usuarios_Usuario_Creacion_Id",
                table: "Departamentos",
                column: "Usuario_Creacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Usuarios_Usuario_Modificacion_Id",
                table: "Departamentos",
                column: "Usuario_Modificacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVentas_Productos_ProductoId",
                table: "DetalleVentas",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVentas_Usuarios_Usuario_Creacion_Id",
                table: "DetalleVentas",
                column: "Usuario_Creacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVentas_Usuarios_Usuario_Modificacion_Id",
                table: "DetalleVentas",
                column: "Usuario_Modificacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVentas_Ventas_VentaId",
                table: "DetalleVentas",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Usuarios_Usuario_Creacion_Id",
                table: "Empleados",
                column: "Usuario_Creacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Usuarios_Usuario_Modificacion_Id",
                table: "Empleados",
                column: "Usuario_Modificacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialSalarials_Usuarios_Usuario_Creacion_Id",
                table: "HistorialSalarials",
                column: "Usuario_Creacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialSalarials_Usuarios_Usuario_Modificacion_Id",
                table: "HistorialSalarials",
                column: "Usuario_Modificacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Usuarios_Usuario_Creacion_Id",
                table: "Productos",
                column: "Usuario_Creacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Usuarios_Usuario_Modificacion_Id",
                table: "Productos",
                column: "Usuario_Modificacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rols_Usuarios_Usuario_Creacion_Id",
                table: "Rols",
                column: "Usuario_Creacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rols_Usuarios_Usuario_Modificacion_Id",
                table: "Rols",
                column: "Usuario_Modificacion_Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Usuarios_Usuario_Creacion_Id",
                table: "Departamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Usuarios_Usuario_Modificacion_Id",
                table: "Departamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Usuarios_Usuario_Creacion_Id",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Usuarios_Usuario_Modificacion_Id",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Rols_Usuarios_Usuario_Creacion_Id",
                table: "Rols");

            migrationBuilder.DropForeignKey(
                name: "FK_Rols_Usuarios_Usuario_Modificacion_Id",
                table: "Rols");

            migrationBuilder.DropTable(
                name: "DetalleVentas");

            migrationBuilder.DropTable(
                name: "HistorialSalarials");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Rols");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}
