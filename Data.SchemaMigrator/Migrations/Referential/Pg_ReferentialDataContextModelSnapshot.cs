﻿// <auto-generated />
using System;
using Data.SchemaMigrator.Models.PgContext.Referential;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Data.SchemaMigrator.Migrations.Referential
{
    [DbContext(typeof(Pg_ReferentialDataContext))]
    partial class Pg_ReferentialDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:pg_buffercache", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:pg_stat_statements", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:pgcrypto", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:pgrouting", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:postgis", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:postgis_topology", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", ",,")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Referential.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnName("createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<Geometry>("TheGeom")
                        .IsRequired()
                        .HasColumnName("the_geom")
                        .HasColumnType("geometry");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .HasName("country_code");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("country_name_key");

                    b.HasIndex("TheGeom")
                        .HasName("country_the_geom")
                        .HasAnnotation("Npgsql:IndexMethod", "gist");

                    b.ToTable("country","referential");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Referential.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnName("createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("IdRefStateFk")
                        .HasColumnName("id_ref_state_fk")
                        .HasColumnType("integer");

                    b.Property<string>("IdSource")
                        .HasColumnName("id_source")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<Geometry>("TheGeom")
                        .IsRequired()
                        .HasColumnName("the_geom")
                        .HasColumnType("geometry");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .HasName("referential_department_code");

                    b.HasIndex("IdRefStateFk");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("department_name_key");

                    b.HasIndex("TheGeom")
                        .HasName("referential_department_the_geom")
                        .HasAnnotation("Npgsql:IndexMethod", "gist");

                    b.ToTable("department","referential");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Referential.LimitsLandSea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.Property<string>("CodeHydro")
                        .HasColumnName("code_hydro")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnName("createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("IdRefCountryFk")
                        .HasColumnName("id_ref_country_fk")
                        .HasColumnType("integer");

                    b.Property<string>("IdSource")
                        .HasColumnName("id_source")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Nature")
                        .HasColumnName("nature")
                        .HasColumnType("text");

                    b.Property<string>("Origine")
                        .HasColumnName("origine")
                        .HasColumnType("text");

                    b.Property<Geometry>("TheGeom")
                        .IsRequired()
                        .HasColumnName("the_geom")
                        .HasColumnType("geometry");

                    b.HasKey("Id");

                    b.HasIndex("IdRefCountryFk");

                    b.HasIndex("TheGeom")
                        .HasName("limits_land_sea_the_geom")
                        .HasAnnotation("Npgsql:IndexMethod", "gist");

                    b.ToTable("limits_land_sea","referential");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Referential.Municipality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnName("createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("IdRefDepartmentFk")
                        .HasColumnName("id_ref_department_fk")
                        .HasColumnType("integer");

                    b.Property<string>("IdSource")
                        .HasColumnName("id_source")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<Geometry>("TheGeom")
                        .IsRequired()
                        .HasColumnName("the_geom")
                        .HasColumnType("geometry");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .HasName("municipality_code");

                    b.HasIndex("IdRefDepartmentFk");

                    b.HasIndex("TheGeom")
                        .HasName("municipality_the_geom")
                        .HasAnnotation("Npgsql:IndexMethod", "gist");

                    b.ToTable("municipality","referential");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Referential.River", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Bras")
                        .HasColumnName("bras")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.Property<string>("CodeHydro")
                        .HasColumnName("code_hydro")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnName("createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("IdRefCountryFk")
                        .HasColumnName("id_ref_country_fk")
                        .HasColumnType("integer");

                    b.Property<int?>("Importance")
                        .HasColumnName("importance")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Nature")
                        .HasColumnName("nature")
                        .HasColumnType("text");

                    b.Property<string>("Origine")
                        .HasColumnName("origine")
                        .HasColumnType("text");

                    b.Property<Geometry>("TheGeom")
                        .IsRequired()
                        .HasColumnName("the_geom")
                        .HasColumnType("geometry");

                    b.HasKey("Id");

                    b.HasIndex("IdRefCountryFk");

                    b.HasIndex("Importance")
                        .HasName("river_importance");

                    b.HasIndex("Name")
                        .HasName("river_name");

                    b.HasIndex("TheGeom")
                        .HasName("river_the_geom")
                        .HasAnnotation("Npgsql:IndexMethod", "gist");

                    b.ToTable("river","referential");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Referential.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnName("createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("IdRefCountryFk")
                        .HasColumnName("id_ref_country_fk")
                        .HasColumnType("integer");

                    b.Property<string>("IdSource")
                        .HasColumnName("id_source")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<Geometry>("TheGeom")
                        .IsRequired()
                        .HasColumnName("the_geom")
                        .HasColumnType("geometry");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .HasName("state_code");

                    b.HasIndex("IdRefCountryFk");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("state_name_key");

                    b.HasIndex("TheGeom")
                        .HasName("state_the_geom")
                        .HasAnnotation("Npgsql:IndexMethod", "gist");

                    b.ToTable("state","referential");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Referential.Department", b =>
                {
                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Referential.State", "IdRefStateFkNavigation")
                        .WithMany("Department")
                        .HasForeignKey("IdRefStateFk")
                        .HasConstraintName("department_id_ref_state_fk_fkey");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Referential.LimitsLandSea", b =>
                {
                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Referential.Country", "IdRefCountryFkNavigation")
                        .WithMany("LimitsLandSea")
                        .HasForeignKey("IdRefCountryFk")
                        .HasConstraintName("limits_land_sea_id_ref_country_fk_fkey");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Referential.Municipality", b =>
                {
                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Referential.Department", "IdRefDepartmentFkNavigation")
                        .WithMany("Municipality")
                        .HasForeignKey("IdRefDepartmentFk")
                        .HasConstraintName("municipality_id_ref_department_fk_fkey");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Referential.River", b =>
                {
                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Referential.Country", "IdRefCountryFkNavigation")
                        .WithMany("River")
                        .HasForeignKey("IdRefCountryFk")
                        .HasConstraintName("river_id_ref_country_fk_fkey");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Referential.State", b =>
                {
                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Referential.Country", "IdRefCountryFkNavigation")
                        .WithMany("State")
                        .HasForeignKey("IdRefCountryFk")
                        .HasConstraintName("state_id_ref_country_fk_fkey");
                });
#pragma warning restore 612, 618
        }
    }
}
