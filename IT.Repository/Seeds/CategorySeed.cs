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
                new Category { Id = 1, Name = "Color",Top=0,UserId=1 },
                new Category { Id = 2, Name = "Purple",Top=0, UserId = 1 },
                new Category { Id = 3, Name = "Blue",Top = 0, UserId = 1 },
                new Category { Id = 4, Name = "Red", Top = 0, UserId = 1 }
                );
        }
    }
}
