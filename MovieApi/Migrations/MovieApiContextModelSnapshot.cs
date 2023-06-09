﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApi.Models;

#nullable disable

namespace MovieApi.Migrations
{
    [DbContext(typeof(MovieApiContext))]
    partial class MovieApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MovieApi.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("ReleaseDate")
                        .HasColumnType("longtext");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Genre = "SciFi",
                            Name = "Ready Player One",
                            ReleaseDate = "2011"
                        },
                        new
                        {
                            MovieId = 2,
                            Genre = "Family",
                            Name = "Land Before Time",
                            ReleaseDate = "1988"
                        },
                        new
                        {
                            MovieId = 3,
                            Genre = "Fantasy",
                            Name = "Matilda",
                            ReleaseDate = "1996"
                        },
                        new
                        {
                            MovieId = 4,
                            Genre = "Sci-fi",
                            Name = "Everything Everywhere All at Once",
                            ReleaseDate = "2022"
                        },
                        new
                        {
                            MovieId = 5,
                            Genre = "Suspense",
                            Name = "I See You",
                            ReleaseDate = "2019"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
