using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Infra.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    CidadeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.CidadeId);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    MarcaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Sigla = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PessoaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    CpfCnpj = table.Column<string>(nullable: true),
                    RgIe = table.Column<string>(nullable: true),
                    Endereco_Logradouro = table.Column<string>(nullable: true),
                    Endereco_Numero = table.Column<string>(nullable: true),
                    Endereco_Bairro = table.Column<string>(nullable: true),
                    Endereco_Complemento = table.Column<string>(nullable: true),
                    Endereco_Cep = table.Column<string>(nullable: true),
                    Endereco_CaixaPostal = table.Column<string>(nullable: true),
                    Endereco_CidadeId = table.Column<int>(nullable: true),
                    TipoPessoa = table.Column<int>(nullable: false),
                    NomePai = table.Column<string>(nullable: true),
                    NomeMae = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    Cnh_Registro = table.Column<string>(nullable: true),
                    Cnh_Validade = table.Column<DateTime>(nullable: true),
                    Cnh_Letra = table.Column<string>(nullable: true),
                    Telefone1 = table.Column<string>(nullable: true),
                    Telefone2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.PessoaId);
                    table.ForeignKey(
                        name: "FK_Pessoas_Cidades_Endereco_CidadeId",
                        column: x => x.Endereco_CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "CidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Placa_Valor = table.Column<string>(nullable: true),
                    Placa_Tipo = table.Column<int>(nullable: false),
                    Renavam = table.Column<string>(nullable: true),
                    Chassi = table.Column<string>(nullable: true),
                    Motor = table.Column<string>(nullable: true),
                    AnoFab = table.Column<string>(nullable: true),
                    AnoModelo = table.Column<string>(nullable: true),
                    DescricaoModelo = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Espelho = table.Column<string>(nullable: true),
                    Categoria = table.Column<int>(nullable: false),
                    Especie = table.Column<int>(nullable: false),
                    Licenciamento = table.Column<int>(nullable: false),
                    Endereco_Logradouro = table.Column<string>(nullable: true),
                    Endereco_Numero = table.Column<string>(nullable: true),
                    Endereco_Bairro = table.Column<string>(nullable: true),
                    Endereco_Complemento = table.Column<string>(nullable: true),
                    Endereco_Cep = table.Column<string>(nullable: true),
                    Endereco_CaixaPostal = table.Column<string>(nullable: true),
                    Endereco_CidadeId = table.Column<int>(nullable: true),
                    PessoaId = table.Column<int>(nullable: true),
                    MarcaId = table.Column<int>(nullable: true),
                    Combustivel = table.Column<string>(nullable: true),
                    Cor = table.Column<string>(nullable: true),
                    NomeProprietarioAnterior = table.Column<string>(nullable: true),
                    CpfCnpjProprietarioAnterior = table.Column<string>(nullable: true),
                    DataDaCompra = table.Column<string>(nullable: true),
                    ValorDaCompra = table.Column<string>(nullable: true),
                    NumeroDaNotaDeCompra = table.Column<string>(nullable: true),
                    NomeComprador = table.Column<string>(nullable: true),
                    CpfCnpjComprador = table.Column<string>(nullable: true),
                    DataVenda = table.Column<string>(nullable: true),
                    ValorVenda = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.VeiculoId);
                    table.ForeignKey(
                        name: "FK_Veiculos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculos_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculos_Cidades_Endereco_CidadeId",
                        column: x => x.Endereco_CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "CidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_Endereco_CidadeId",
                table: "Pessoas",
                column: "Endereco_CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_MarcaId",
                table: "Veiculos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_PessoaId",
                table: "Veiculos",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_Endereco_CidadeId",
                table: "Veiculos",
                column: "Endereco_CidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Cidades");
        }
    }
}
