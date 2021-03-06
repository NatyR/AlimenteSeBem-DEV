﻿// <auto-generated />
using alimentesebem.sesi.repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace alimentesebem.sesi.repository.Migrations
{
    [DbContext(typeof(ISesiContext))]
    partial class ISesiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data_Evento");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<int>("Id_Unidade");

                    b.Property<string>("Tag")
                        .HasMaxLength(300);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Valor")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Id_Unidade");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Alternativas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("A")
                        .IsRequired();

                    b.Property<string>("B")
                        .IsRequired();

                    b.Property<string>("C")
                        .IsRequired();

                    b.Property<string>("D")
                        .IsRequired();

                    b.Property<string>("E")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Alternativas");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Categorias_Noticias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Categorias_Noticias");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Categorias_Videos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Categorias_Videos");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Dispositivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Id_Restaurante");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Serial")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Id_Restaurante");

                    b.HasIndex("Serial")
                        .IsUnique();

                    b.ToTable("Dispositivo");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Noticias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data_Criacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(10000);

                    b.Property<string>("Headline")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("Id_Cat_Noticias");

                    b.Property<string>("Imagem")
                        .IsRequired();

                    b.Property<string>("Link_Externo");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Id_Cat_Noticias");

                    b.ToTable("Noticias");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Nutricionista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("NIF");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NIF")
                        .IsUnique();

                    b.ToTable("Nutricionista");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Perguntas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data_Fim");

                    b.Property<DateTime>("Data_Inicio");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Id_Alternativa");

                    b.Property<int>("Id_Dispositivo");

                    b.Property<string>("Ordem")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.HasIndex("Id_Alternativa");

                    b.HasIndex("Id_Dispositivo");

                    b.ToTable("Perguntas");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Permissao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Permissao");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Respostas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data_Resposta");

                    b.Property<int>("Id_Pergunta");

                    b.Property<string>("Resposta")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Id_Pergunta");

                    b.ToTable("Respostas");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Restaurante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Restaurante");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Unidades_Sesi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Codigo_Unidade")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Unidades_Sesi");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Videos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data_Publicacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(800);

                    b.Property<int>("Id_Cat_Videos");

                    b.Property<string>("Link_Externo");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.HasIndex("Id_Cat_Videos");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Agenda", b =>
                {
                    b.HasOne("alimentesebem.sesi.domain.Entities.Unidades_Sesi", "Unidades_Sesi")
                        .WithMany()
                        .HasForeignKey("Id_Unidade")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Dispositivo", b =>
                {
                    b.HasOne("alimentesebem.sesi.domain.Entities.Restaurante", "Restaurante")
                        .WithMany()
                        .HasForeignKey("Id_Restaurante")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Noticias", b =>
                {
                    b.HasOne("alimentesebem.sesi.domain.Entities.Categorias_Noticias", "Categorias_Noticias")
                        .WithMany("Noticias")
                        .HasForeignKey("Id_Cat_Noticias")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Perguntas", b =>
                {
                    b.HasOne("alimentesebem.sesi.domain.Entities.Alternativas", "Alternativas")
                        .WithMany()
                        .HasForeignKey("Id_Alternativa")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("alimentesebem.sesi.domain.Entities.Dispositivo", "Dispositivo")
                        .WithMany()
                        .HasForeignKey("Id_Dispositivo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Respostas", b =>
                {
                    b.HasOne("alimentesebem.sesi.domain.Entities.Perguntas", "Perguntas")
                        .WithMany("Respostas")
                        .HasForeignKey("Id_Pergunta")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("alimentesebem.sesi.domain.Entities.Videos", b =>
                {
                    b.HasOne("alimentesebem.sesi.domain.Entities.Categorias_Videos", "Categorias_Videos")
                        .WithMany("Videos")
                        .HasForeignKey("Id_Cat_Videos")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
