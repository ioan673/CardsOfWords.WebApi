﻿// <auto-generated />
using CardsOfWords.WebApi.Words.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CardsOfWords.WebApi.Words.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220810101927_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CardsOfWords.WebApi.Words.Data.Entities.AppVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AppVersions");
                });

            modelBuilder.Entity("CardsOfWords.WebApi.Words.Data.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("CardsOfWords.WebApi.Words.Data.Entities.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("RusWord")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Transcription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TranslateWord")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WordGroupId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WordGroupId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("CardsOfWords.WebApi.Words.Data.Entities.WordGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("LanguageId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("WordGroups");
                });

            modelBuilder.Entity("CardsOfWords.WebApi.Words.Data.Entities.Word", b =>
                {
                    b.HasOne("CardsOfWords.WebApi.Words.Data.Entities.WordGroup", "WordGroup")
                        .WithMany()
                        .HasForeignKey("WordGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WordGroup");
                });

            modelBuilder.Entity("CardsOfWords.WebApi.Words.Data.Entities.WordGroup", b =>
                {
                    b.HasOne("CardsOfWords.WebApi.Words.Data.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });
#pragma warning restore 612, 618
        }
    }
}
