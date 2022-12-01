﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SdHub.Database;
using SdHub.Services.FileProc.Metadata;

#nullable disable

namespace SdHub.Database.Migrations
{
    [DbContext(typeof(SdHubDbContext))]
    [Migration("20221130204122_Upd6")]
    partial class Upd6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SdHub.Database.Entities.Bins.EmbeddingEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("SdVersion")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Embeddings");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.EmbeddingVersionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<long>("EmbeddingId")
                        .HasColumnType("bigint");

                    b.Property<long>("FileId")
                        .HasColumnType("bigint");

                    b.Property<List<string>>("KnownNames")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("SourceLink")
                        .HasColumnType("text");

                    b.Property<string>("Version")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EmbeddingId");

                    b.HasIndex("FileId");

                    b.ToTable("EmbeddingVersions");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.GenerationSampleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("HypernetVersionId")
                        .HasColumnType("bigint");

                    b.Property<long>("ImageId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ModelVersionId")
                        .HasColumnType("bigint");

                    b.Property<long?>("VaeVersionId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("HypernetVersionId");

                    b.HasIndex("ImageId");

                    b.HasIndex("ModelVersionId");

                    b.HasIndex("VaeVersionId");

                    b.ToTable("GenerationSamples");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.HypernetEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("SdVersion")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Hypernets");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.HypernetVersionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<long>("FileId")
                        .HasColumnType("bigint");

                    b.Property<long>("HypernetId")
                        .HasColumnType("bigint");

                    b.Property<List<string>>("KnownNames")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("SourceLink")
                        .HasColumnType("text");

                    b.Property<string>("Version")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("HypernetId");

                    b.ToTable("HypernetVersions");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.ModelEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("SdVersion")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.ModelVersionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<long>("CkptFileId")
                        .HasColumnType("bigint");

                    b.Property<string>("HashV1")
                        .HasColumnType("text");

                    b.Property<List<string>>("KnownNames")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<long>("ModelId")
                        .HasColumnType("bigint");

                    b.Property<string>("SourceLink")
                        .HasColumnType("text");

                    b.Property<string>("Version")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CkptFileId");

                    b.HasIndex("ModelId");

                    b.ToTable("ModelVersions");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.VaeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("SdVersion")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Vaes");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.VaeVersionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<long>("FileId")
                        .HasColumnType("bigint");

                    b.Property<List<string>>("KnownNames")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<long?>("ModelId")
                        .HasColumnType("bigint");

                    b.Property<string>("SourceLink")
                        .HasColumnType("text");

                    b.Property<long>("VaeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Version")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("ModelId");

                    b.ToTable("VaeVersions");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Files.DirectoryEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PathOnStorage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<string>("StorageName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StorageName");

                    b.ToTable("Dirs");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Files.FileEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MimeType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PathOnStorage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<string>("StorageName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StorageName");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Files.FileStorageEntity", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte>("BackendType")
                        .HasColumnType("smallint");

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Settings")
                        .HasColumnType("text");

                    b.Property<int>("Version")
                        .HasColumnType("integer");

                    b.HasKey("Name");

                    b.ToTable("FileStorages");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Images.ImageEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("CompressedImageId")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ManageToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("OriginalImageId")
                        .HasColumnType("bigint");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<string>("ShortToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("ThumbImageId")
                        .HasColumnType("bigint");

                    b.Property<long>("UploaderId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CompressedImageId");

                    b.HasIndex("OriginalImageId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ThumbImageId");

                    b.HasIndex("UploaderId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Images.ImageParsedMetadataEntity", b =>
                {
                    b.Property<long>("ImageId")
                        .HasColumnType("bigint");

                    b.Property<int>("Height")
                        .HasColumnType("integer");

                    b.Property<int>("Width")
                        .HasColumnType("integer");

                    b.HasKey("ImageId");

                    b.ToTable("ImageParsedMetadata");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Images.ImageParsedMetadataTagEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("MetadataId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Software")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MetadataId");

                    b.ToTable("ImageParsedMetadataTags");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Images.ImageRawMetadataEntity", b =>
                {
                    b.Property<long>("ImageId")
                        .HasColumnType("bigint");

                    b.Property<IReadOnlyList<ImageMetadataDirectory>>("Directories")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.HasKey("ImageId");

                    b.ToTable("ImageRawMetadata");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Images.ImageUploaderEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IpAddress")
                        .IsUnique();

                    b.ToTable("ImageUploaders");
                });

            modelBuilder.Entity("SdHub.Database.Entities.TempCodeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CodeType")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CurrAttempts")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("ExpiredAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MaxAttempts")
                        .HasColumnType("integer");

                    b.Property<bool>("Used")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("TempCodes");
                });

            modelBuilder.Entity("SdHub.Database.Entities.User.RefreshTokenEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("ExpiredAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IpAddress")
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("UsedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserAgent")
                        .HasColumnType("text");

                    b.Property<long?>("UserEntityId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("UserGuid")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Token")
                        .IsUnique();

                    b.HasIndex("UserEntityId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("SdHub.Database.Entities.User.UserEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("EmailConfirmationLastSend")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("EmailConfirmedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EmailNormalized")
                        .HasColumnType("text");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsAnonymous")
                        .HasColumnType("boolean");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("LoginNormalized")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("PlanId")
                        .HasColumnType("bigint");

                    b.Property<List<string>>("Roles")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.HasKey("Id");

                    b.HasIndex("Guid")
                        .IsUnique();

                    b.HasIndex("PlanId");

                    b.HasIndex("LoginNormalized", "DeletedAt")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Users.UserPlanEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("ImagesPerHour")
                        .HasColumnType("integer");

                    b.Property<int>("ImagesPerUpload")
                        .HasColumnType("integer");

                    b.Property<int>("MaxArchiveSizeUpload")
                        .HasColumnType("integer");

                    b.Property<int>("MaxImageSizeUpload")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("OnlyWithMetadata")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("UserPlans");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.EmbeddingVersionEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Bins.EmbeddingEntity", "Embedding")
                        .WithMany()
                        .HasForeignKey("EmbeddingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SdHub.Database.Entities.Files.FileEntity", "File")
                        .WithMany()
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Embedding");

                    b.Navigation("File");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.GenerationSampleEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Bins.HypernetVersionEntity", "HypernetVersion")
                        .WithMany()
                        .HasForeignKey("HypernetVersionId");

                    b.HasOne("SdHub.Database.Entities.Images.ImageEntity", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SdHub.Database.Entities.Bins.ModelVersionEntity", "ModelVersion")
                        .WithMany()
                        .HasForeignKey("ModelVersionId");

                    b.HasOne("SdHub.Database.Entities.Bins.VaeVersionEntity", "VaeVersion")
                        .WithMany()
                        .HasForeignKey("VaeVersionId");

                    b.Navigation("HypernetVersion");

                    b.Navigation("Image");

                    b.Navigation("ModelVersion");

                    b.Navigation("VaeVersion");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.HypernetVersionEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Files.FileEntity", "File")
                        .WithMany()
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SdHub.Database.Entities.Bins.HypernetEntity", "Hypernet")
                        .WithMany()
                        .HasForeignKey("HypernetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("File");

                    b.Navigation("Hypernet");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.ModelVersionEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Files.FileEntity", "CkptFile")
                        .WithMany()
                        .HasForeignKey("CkptFileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SdHub.Database.Entities.Bins.ModelEntity", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CkptFile");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Bins.VaeVersionEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Files.FileEntity", "File")
                        .WithMany()
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SdHub.Database.Entities.Bins.VaeEntity", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.Navigation("File");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Files.DirectoryEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Files.FileStorageEntity", "Storage")
                        .WithMany()
                        .HasForeignKey("StorageName");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Files.FileEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Files.FileStorageEntity", "Storage")
                        .WithMany()
                        .HasForeignKey("StorageName");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Images.ImageEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Files.FileEntity", "CompressedImage")
                        .WithMany()
                        .HasForeignKey("CompressedImageId");

                    b.HasOne("SdHub.Database.Entities.Files.FileEntity", "OriginalImage")
                        .WithMany()
                        .HasForeignKey("OriginalImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SdHub.Database.Entities.User.UserEntity", "Owner")
                        .WithMany("Images")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SdHub.Database.Entities.Files.FileEntity", "ThumbImage")
                        .WithMany()
                        .HasForeignKey("ThumbImageId");

                    b.HasOne("SdHub.Database.Entities.Images.ImageUploaderEntity", "Uploader")
                        .WithMany()
                        .HasForeignKey("UploaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompressedImage");

                    b.Navigation("OriginalImage");

                    b.Navigation("Owner");

                    b.Navigation("ThumbImage");

                    b.Navigation("Uploader");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Images.ImageParsedMetadataEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Images.ImageEntity", "Image")
                        .WithOne("ParsedMetadata")
                        .HasForeignKey("SdHub.Database.Entities.Images.ImageParsedMetadataEntity", "ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Images.ImageParsedMetadataTagEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Images.ImageParsedMetadataEntity", "Metadata")
                        .WithMany("Tags")
                        .HasForeignKey("MetadataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Metadata");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Images.ImageRawMetadataEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Images.ImageEntity", "Image")
                        .WithOne("RawMetadata")
                        .HasForeignKey("SdHub.Database.Entities.Images.ImageRawMetadataEntity", "ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("SdHub.Database.Entities.User.RefreshTokenEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.User.UserEntity", null)
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("SdHub.Database.Entities.User.UserEntity", b =>
                {
                    b.HasOne("SdHub.Database.Entities.Users.UserPlanEntity", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Images.ImageEntity", b =>
                {
                    b.Navigation("ParsedMetadata");

                    b.Navigation("RawMetadata");
                });

            modelBuilder.Entity("SdHub.Database.Entities.Images.ImageParsedMetadataEntity", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("SdHub.Database.Entities.User.UserEntity", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("RefreshTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
