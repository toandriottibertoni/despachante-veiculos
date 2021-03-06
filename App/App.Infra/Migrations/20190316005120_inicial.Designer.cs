﻿// <auto-generated />
using System;
using App.Infra.Persistencia.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Infra.Migrations
{
    [DbContext(typeof(EfContexto))]
    [Migration("20190316005120_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("App.Domain.Entidades.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Uf");

                    b.HasKey("CidadeId");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("App.Domain.Entidades.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Sigla");

                    b.HasKey("MarcaId");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("App.Domain.Entidades.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CpfCnpj");

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Nome");

                    b.Property<string>("NomeMae");

                    b.Property<string>("NomePai");

                    b.Property<string>("RgIe");

                    b.Property<string>("Telefone1");

                    b.Property<string>("Telefone2");

                    b.Property<int>("TipoPessoa");

                    b.HasKey("PessoaId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("App.Domain.Entidades.Veiculo", b =>
                {
                    b.Property<int>("VeiculoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnoFab");

                    b.Property<string>("AnoModelo");

                    b.Property<bool>("Ativo");

                    b.Property<int>("Categoria");

                    b.Property<string>("Chassi");

                    b.Property<string>("Combustivel");

                    b.Property<string>("Cor");

                    b.Property<string>("CpfCnpjComprador");

                    b.Property<string>("CpfCnpjProprietarioAnterior");

                    b.Property<string>("DataDaCompra");

                    b.Property<string>("DataVenda");

                    b.Property<string>("DescricaoModelo");

                    b.Property<int>("Especie");

                    b.Property<string>("Espelho");

                    b.Property<int>("Licenciamento");

                    b.Property<int?>("MarcaId");

                    b.Property<string>("Motor");

                    b.Property<string>("NomeComprador");

                    b.Property<string>("NomeProprietarioAnterior");

                    b.Property<string>("NumeroDaNotaDeCompra");

                    b.Property<int?>("PessoaId");

                    b.Property<string>("Renavam");

                    b.Property<string>("ValorDaCompra");

                    b.Property<string>("ValorVenda");

                    b.HasKey("VeiculoId");

                    b.HasIndex("MarcaId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("App.Domain.Entidades.Pessoa", b =>
                {
                    b.OwnsOne("App.Domain.ObjetosDeValor.Cnh", "Cnh", b1 =>
                        {
                            b1.Property<int>("PessoaId");

                            b1.Property<string>("Letra");

                            b1.Property<string>("Registro");

                            b1.Property<DateTime?>("Validade");

                            b1.HasKey("PessoaId");

                            b1.ToTable("Pessoas");

                            b1.HasOne("App.Domain.Entidades.Pessoa")
                                .WithOne("Cnh")
                                .HasForeignKey("App.Domain.ObjetosDeValor.Cnh", "PessoaId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("App.Domain.ObjetosDeValor.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("PessoaId");

                            b1.Property<string>("Bairro");

                            b1.Property<string>("CaixaPostal");

                            b1.Property<string>("Cep");

                            b1.Property<int?>("CidadeId");

                            b1.Property<string>("Complemento");

                            b1.Property<string>("Logradouro");

                            b1.Property<string>("Numero");

                            b1.HasKey("PessoaId");

                            b1.HasIndex("CidadeId");

                            b1.ToTable("Pessoas");

                            b1.HasOne("App.Domain.Entidades.Cidade", "Cidade")
                                .WithMany()
                                .HasForeignKey("CidadeId");

                            b1.HasOne("App.Domain.Entidades.Pessoa")
                                .WithOne("Endereco")
                                .HasForeignKey("App.Domain.ObjetosDeValor.Endereco", "PessoaId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("App.Domain.Entidades.Veiculo", b =>
                {
                    b.HasOne("App.Domain.Entidades.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId");

                    b.HasOne("App.Domain.Entidades.Pessoa", "Pessoa")
                        .WithMany("Veiculos")
                        .HasForeignKey("PessoaId");

                    b.OwnsOne("App.Domain.ObjetosDeValor.Placa", "Placa", b1 =>
                        {
                            b1.Property<int>("VeiculoId");

                            b1.Property<int>("Tipo");

                            b1.Property<string>("Valor");

                            b1.HasKey("VeiculoId");

                            b1.ToTable("Veiculos");

                            b1.HasOne("App.Domain.Entidades.Veiculo")
                                .WithOne("Placa")
                                .HasForeignKey("App.Domain.ObjetosDeValor.Placa", "VeiculoId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("App.Domain.ObjetosDeValor.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("VeiculoId");

                            b1.Property<string>("Bairro");

                            b1.Property<string>("CaixaPostal");

                            b1.Property<string>("Cep");

                            b1.Property<int?>("CidadeId");

                            b1.Property<string>("Complemento");

                            b1.Property<string>("Logradouro");

                            b1.Property<string>("Numero");

                            b1.HasKey("VeiculoId");

                            b1.HasIndex("CidadeId");

                            b1.ToTable("Veiculos");

                            b1.HasOne("App.Domain.Entidades.Cidade", "Cidade")
                                .WithMany()
                                .HasForeignKey("CidadeId");

                            b1.HasOne("App.Domain.Entidades.Veiculo")
                                .WithOne("Endereco")
                                .HasForeignKey("App.Domain.ObjetosDeValor.Endereco", "VeiculoId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
