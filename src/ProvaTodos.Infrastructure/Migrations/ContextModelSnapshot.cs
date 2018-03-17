﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProvaTodos.Infrastructure;
using System;

namespace ProvaTodos.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProvaTodos.Domain.OperacaoUsuario", b =>
                {
                    b.Property<int>("Id_Usuario");

                    b.Property<int>("Id_Operacao_Acesso");

                    b.Property<DateTime>("Dt_Log");

                    b.HasKey("Id_Usuario", "Id_Operacao_Acesso");

                    b.ToTable("OperacaoUsuario");
                });

            modelBuilder.Entity("ProvaTodos.Domain.Perfil", b =>
                {
                    b.Property<int>("Id_Perfil")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id_Perfil");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("ProvaTodos.Domain.Usuario", b =>
                {
                    b.Property<int>("Id_Usuario")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("Dt_Inclusao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id_Usuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProvaTodos.Domain.UsuarioPerfil", b =>
                {
                    b.Property<int>("Id_Usuario");

                    b.Property<int>("Id_Perfil");

                    b.Property<bool>("Ativo");

                    b.HasKey("Id_Usuario", "Id_Perfil");

                    b.HasIndex("Id_Perfil");

                    b.ToTable("UsuarioPerfil");
                });

            modelBuilder.Entity("ProvaTodos.Domain.OperacaoUsuario", b =>
                {
                    b.HasOne("ProvaTodos.Domain.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Id_Usuario")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProvaTodos.Domain.UsuarioPerfil", b =>
                {
                    b.HasOne("ProvaTodos.Domain.Perfil", "Perfil")
                        .WithMany("Usuarios")
                        .HasForeignKey("Id_Perfil")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProvaTodos.Domain.Usuario", "Usuario")
                        .WithMany("Perfis")
                        .HasForeignKey("Id_Usuario")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
