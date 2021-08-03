using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    internal class SeedBooks : IEntityTypeConfiguration<Book>
    {

        public void Configure(EntityTypeBuilder<Book> entity)
        {
            entity.HasData(
                new Book { BookId = 1, Title = "1776", GenreId = "history", Price = 18.00 },
                new Book { BookId = 2, Title = "1984", GenreId = "scifi", Price = 5.50 },
                new Book { BookId = 3, Title = "Harry Potter and the Sorcerer's Stone", GenreId = "novel", Price = 9.75 },
                new Book { BookId = 4, Title = "Project Hail Mary", GenreId = "scifi", Price = 12.25 }

                );
        }
    }
}
