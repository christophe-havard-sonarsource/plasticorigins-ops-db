﻿// <auto-generated />
using System;
using System.Collections;
using Data.SchemaMigrator.Models.PgContext.Label;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Data.SchemaMigrator.Migrations.Label
{
    [DbContext(typeof(Pg_LabelDataContext))]
    [Migration("20200508081541_AddLabelSchemaMigration")]
    partial class AddLabelSchemaMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Campaign.Campaign", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BlobName")
                        .HasColumnType("text");

                    b.Property<string>("ContainerUrl")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("IdRefModelFk")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefModelFkNavigationId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefUserFk")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefUserFkNavigationId")
                        .HasColumnType("uuid");

                    b.Property<bool?>("Isaidriven")
                        .HasColumnType("boolean");

                    b.Property<string>("Locomotion")
                        .HasColumnType("text");

                    b.Property<string>("Remark")
                        .HasColumnType("text");

                    b.Property<string>("Riverside")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdRefModelFkNavigationId");

                    b.HasIndex("IdRefUserFkNavigationId");

                    b.ToTable("Campaign");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Campaign.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Blobname")
                        .HasColumnType("text");

                    b.Property<string>("Containerurl")
                        .HasColumnType("text");

                    b.Property<string>("Createdby")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Filename")
                        .HasColumnType("text");

                    b.Property<Guid?>("IdRefCampaignFk")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefCampaignFkNavigationId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefTrajectoryPointsFk")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefTrajectoryPointsFkNavigationId")
                        .HasColumnType("uuid");

                    b.Property<BitArray>("Isdeleted")
                        .HasColumnType("bit varying");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Version")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdRefCampaignFkNavigationId");

                    b.HasIndex("IdRefTrajectoryPointsFkNavigationId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Campaign.Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("Version")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Model");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Campaign.TrajectoryPoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double?>("Distance")
                        .HasColumnType("double precision");

                    b.Property<double?>("Elevation")
                        .HasColumnType("double precision");

                    b.Property<Guid>("IdRefCampaignFk")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefCampaignFkNavigationId")
                        .HasColumnType("uuid");

                    b.Property<double?>("Lat")
                        .HasColumnType("double precision");

                    b.Property<double?>("Lon")
                        .HasColumnType("double precision");

                    b.Property<double?>("Speed")
                        .HasColumnType("double precision");

                    b.Property<Geometry>("TheGeom")
                        .HasColumnType("geometry");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<TimeSpan?>("TimeDiff")
                        .HasColumnType("interval");

                    b.HasKey("Id");

                    b.HasIndex("IdRefCampaignFkNavigationId");

                    b.ToTable("TrajectoryPoint");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Campaign.Trash", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BrandType")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double?>("Elevation")
                        .HasColumnType("double precision");

                    b.Property<Guid>("IdRefCampaignFk")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefCampaignFkNavigationId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefImageFk")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefImageFkNavigationId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefModelFk")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRefModelFkNavigationId")
                        .HasColumnType("uuid");

                    b.Property<int>("IdRefTrashTypeFk")
                        .HasColumnType("integer");

                    b.Property<int?>("IdRefTrashTypeFkNavigationId")
                        .HasColumnType("integer");

                    b.Property<double?>("Lat")
                        .HasColumnType("double precision");

                    b.Property<double?>("Lon")
                        .HasColumnType("double precision");

                    b.Property<double?>("Precision")
                        .HasColumnType("double precision");

                    b.Property<Geometry>("TheGeom")
                        .HasColumnType("geometry");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("IdRefCampaignFkNavigationId");

                    b.HasIndex("IdRefImageFkNavigationId");

                    b.HasIndex("IdRefModelFkNavigationId");

                    b.HasIndex("IdRefTrashTypeFkNavigationId");

                    b.ToTable("Trash");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Campaign.TrashType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TrashType");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Campaign.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("Emailconfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Experience")
                        .HasColumnType("text");

                    b.Property<string>("Firstname")
                        .HasColumnType("text");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Lastname")
                        .HasColumnType("text");

                    b.Property<string>("Passwordhash")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Yearofbirth")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Label.BoundingBoxes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Height")
                        .HasColumnName("height")
                        .HasColumnType("integer");

                    b.Property<Guid>("IdCreatorFk")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdRefImagesForLabelling")
                        .HasColumnType("uuid");

                    b.Property<int>("IdRefTrashTypeFk")
                        .HasColumnType("integer");

                    b.Property<int>("LocationX")
                        .HasColumnName("locationX")
                        .HasColumnType("integer");

                    b.Property<int>("LocationY")
                        .HasColumnName("locationY")
                        .HasColumnType("integer");

                    b.Property<int>("Width")
                        .HasColumnName("width")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdCreatorFk");

                    b.HasIndex("IdRefImagesForLabelling");

                    b.HasIndex("IdRefTrashTypeFk");

                    b.ToTable("bounding_boxes","label");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Label.ImagesForLabelling", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("BlobName")
                        .HasColumnName("blob_name")
                        .HasColumnType("text");

                    b.Property<string>("ContainerUrl")
                        .HasColumnName("container_url")
                        .HasColumnType("text");

                    b.Property<string>("Context")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("createdon")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Filename")
                        .HasColumnName("filename")
                        .HasColumnType("text");

                    b.Property<Guid>("IdCreatorFk")
                        .HasColumnType("uuid");

                    b.Property<string>("ImageQuality")
                        .HasColumnName("image_quality")
                        .HasColumnType("text");

                    b.Property<string>("View")
                        .HasColumnName("view")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdCreatorFk");

                    b.ToTable("images_for_labelling","label");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Campaign.Campaign", b =>
                {
                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.Model", "IdRefModelFkNavigation")
                        .WithMany("Campaign")
                        .HasForeignKey("IdRefModelFkNavigationId");

                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.User", "IdRefUserFkNavigation")
                        .WithMany("Campaign")
                        .HasForeignKey("IdRefUserFkNavigationId");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Campaign.Image", b =>
                {
                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.Campaign", "IdRefCampaignFkNavigation")
                        .WithMany("Image")
                        .HasForeignKey("IdRefCampaignFkNavigationId");

                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.TrajectoryPoint", "IdRefTrajectoryPointsFkNavigation")
                        .WithMany("Image")
                        .HasForeignKey("IdRefTrajectoryPointsFkNavigationId");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Campaign.TrajectoryPoint", b =>
                {
                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.Campaign", "IdRefCampaignFkNavigation")
                        .WithMany("TrajectoryPoint")
                        .HasForeignKey("IdRefCampaignFkNavigationId");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Campaign.Trash", b =>
                {
                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.Campaign", "IdRefCampaignFkNavigation")
                        .WithMany("Trash")
                        .HasForeignKey("IdRefCampaignFkNavigationId");

                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.Image", "IdRefImageFkNavigation")
                        .WithMany("Trash")
                        .HasForeignKey("IdRefImageFkNavigationId");

                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.Model", "IdRefModelFkNavigation")
                        .WithMany("Trash")
                        .HasForeignKey("IdRefModelFkNavigationId");

                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.TrashType", "IdRefTrashTypeFkNavigation")
                        .WithMany("Trash")
                        .HasForeignKey("IdRefTrashTypeFkNavigationId");
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Label.BoundingBoxes", b =>
                {
                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.User", "Creator")
                        .WithMany("UserBoundingBoxesNavigation")
                        .HasForeignKey("IdCreatorFk")
                        .HasConstraintName("id_creator_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Label.ImagesForLabelling", "ImageForLabelling")
                        .WithMany("ImagesForLabellingBoundingBoxesNavigation")
                        .HasForeignKey("IdRefImagesForLabelling")
                        .HasConstraintName("id_ref_images_for_labelling_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.TrashType", "TrashType")
                        .WithMany("TrashTypeBoundingBoxesNavigation")
                        .HasForeignKey("IdRefTrashTypeFk")
                        .HasConstraintName("id_ref_trash_type_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.SchemaMigrator.Models.PgContext.Label.ImagesForLabelling", b =>
                {
                    b.HasOne("Data.SchemaMigrator.Models.PgContext.Campaign.User", "Creator")
                        .WithMany("ImagesForLabellings")
                        .HasForeignKey("IdCreatorFk")
                        .HasConstraintName("id_creator_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
