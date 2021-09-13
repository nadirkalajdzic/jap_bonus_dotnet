using JapBonusDotnet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapBonusDotnet.DbContexts
{
    public class BandAlbumContext: DbContext
    {
        public BandAlbumContext(DbContextOptions<BandAlbumContext> options) : base(options) {}

        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Band>().HasData(
                new Band 
                { 
                    Id = Guid.Parse("6bde47fc-0803-451c-90d6-5e762ff22591"),
                    Name = "Metallica",
                    Founded = new DateTime(1980,1,1),
                    MainGenre = "Heavy Metal"
                },
                new Band
                {
                    Id = Guid.Parse("d8b9ce20-0264-4d8b-9acf-86d5edd05aa0"),
                    Name = "Oasis",
                    Founded = new DateTime(1991, 12, 1),
                    MainGenre = "Alternative"
                },
                new Band
                {
                    Id = Guid.Parse("1d9b71c0-7b74-4b43-987b-66221631507f"),
                    Name = "Guns N Roses",
                    Founded = new DateTime(1985, 2, 1),
                    MainGenre = "Rock"
                }
            );

            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    Id = Guid.Parse("77549e74-b4ed-428f-b940-971665bae20e"),
                    Title = "Master of Puppets",
                    Description = "One of the best heavy metal albums ever.",
                    BandId = Guid.Parse("6bde47fc-0803-451c-90d6-5e762ff22591")
                },
                new Album
                {
                    Id = Guid.Parse("45a44e6b-f60c-4d0a-860e-ad21416c481f"),
                    Title = "Appetite for Desctrution",
                    Description = "Amazing album with raw sound.",
                    BandId = Guid.Parse("1d9b71c0-7b74-4b43-987b-66221631507f")
                },
                new Album
                {
                    Id = Guid.Parse("a05453d5-863e-4110-84b7-f1128ab16cab"),
                    Title = "Be Here Now",
                    Description = "Arguably one of the best albums by Oasis",
                    BandId = Guid.Parse("d8b9ce20-0264-4d8b-9acf-86d5edd05aa0")
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
