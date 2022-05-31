using IT.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 0, Name = "Color" },
                new Category { Id = 1, Name = "Purple",Top=0 },
                new Category { Id = 2, Name = "Blue",Top = 0 },
                new Category { Id = 3, Name = "Red", Top = 0 }
                );
        }
    }
}
