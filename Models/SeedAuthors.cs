using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    internal class SeedAuthors : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> entity)
        {
            entity.HasData(
                new Author { AuthorId = 1, FirstName = "Michelle", LastName = "Alexander"},
                new Author { AuthorId = 2, FirstName = "Stephen E.", LastName = "Ambrose" },
                new Author { AuthorId = 3, FirstName = "Seth", LastName = "Grahame-Smith" },
                new Author { AuthorId = 4, FirstName = "Andy", LastName = "Weir" }

                );
        }
    }
}
