﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp.Data;

namespace MovieApp.Migrations
{
    [DbContext(typeof(MarvelUniverseDbContext))]
    [Migration("20220301092844_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.Property<int>("CharactersId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("CharactersId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CharacterMovie");
                });

            modelBuilder.Entity("MovieApp.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PictureUrl")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Character");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alias = "Human",
                            FullName = "Batman",
                            Gender = "Male",
                            PictureUrl = "https://static.wikia.nocookie.net/batman/images/8/8f/Christian_Bale_as_The_Dark_Knight.jpg/revision/latest/scale-to-width-down/967?cb=20210312234853"
                        },
                        new
                        {
                            Id = 2,
                            Alias = "Human",
                            FullName = "Commissioner Gordon",
                            Gender = "Male",
                            PictureUrl = "https://static.wikia.nocookie.net/batman/images/c/ca/Batman_photos_oldman.jpg/revision/latest/scale-to-width-down/300?cb=20080321214518"
                        },
                        new
                        {
                            Id = 3,
                            Alias = "Human",
                            FullName = "Bane",
                            Gender = "Male",
                            PictureUrl = "https://static.wikia.nocookie.net/batman/images/f/f0/Bane_TDKR3.jpg/revision/latest/scale-to-width-down/470?cb=20120511112335"
                        },
                        new
                        {
                            Id = 4,
                            Alias = "Hobbit",
                            FullName = "Frodo Baggins",
                            Gender = "Male",
                            PictureUrl = "https://static.wikia.nocookie.net/lotr/images/1/1a/FotR_-_Elijah_Wood_as_Frodo.png/revision/latest/scale-to-width-down/1000?cb=20130313174543"
                        },
                        new
                        {
                            Id = 5,
                            Alias = "Maiar",
                            FullName = "Saruman the White",
                            Gender = "Male",
                            PictureUrl = "https://static.wikia.nocookie.net/lotr/images/0/0c/Christopher_Lee_as_Saruman.jpg/revision/latest?cb=20170127113833"
                        },
                        new
                        {
                            Id = 6,
                            Alias = "Dunedain",
                            FullName = "Aragorn",
                            Gender = "Male",
                            PictureUrl = "https://static.wikia.nocookie.net/lotr/images/b/b6/Aragorn_profile.jpg/revision/latest?cb=20170121121423"
                        });
                });

            modelBuilder.Entity("MovieApp.Models.Franchise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Franchise");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Batman Nolanverse"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lord of the Rings"
                        });
                });

            modelBuilder.Entity("MovieApp.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("FranchiseId")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("PictureUrl")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Trailer")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("FranchiseId");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Director = "Christopher Nolan",
                            FranchiseId = 1,
                            Genre = "Action",
                            PictureUrl = "",
                            ReleaseYear = 2005,
                            Title = "Batman Begins",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 2,
                            Director = "Christopher Nolan",
                            FranchiseId = 1,
                            Genre = "Action",
                            PictureUrl = "",
                            ReleaseYear = 2008,
                            Title = "The Dark Knight",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 3,
                            Director = "Christopher Nolan",
                            FranchiseId = 1,
                            Genre = "Action",
                            PictureUrl = "",
                            ReleaseYear = 2012,
                            Title = "The Dark Knight Rises",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 4,
                            Director = "Peter Jackson",
                            FranchiseId = 2,
                            Genre = "Fantasy",
                            PictureUrl = "",
                            ReleaseYear = 2001,
                            Title = "The Fellowship of the Ring",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 5,
                            Director = "Peter Jackson",
                            FranchiseId = 2,
                            Genre = "Fantasy",
                            PictureUrl = "",
                            ReleaseYear = 2003,
                            Title = "The Two Towers",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 6,
                            Director = "Peter Jackson",
                            FranchiseId = 2,
                            Genre = "Fantasy",
                            PictureUrl = "",
                            ReleaseYear = 2005,
                            Title = "The Return of the King",
                            Trailer = ""
                        });
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.HasOne("MovieApp.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieApp.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieApp.Models.Movie", b =>
                {
                    b.HasOne("MovieApp.Models.Franchise", "Franchise")
                        .WithMany("Movies")
                        .HasForeignKey("FranchiseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Franchise");
                });

            modelBuilder.Entity("MovieApp.Models.Franchise", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
