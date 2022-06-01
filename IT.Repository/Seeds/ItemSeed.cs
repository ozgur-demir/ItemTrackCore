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
    internal class ItemSeed : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasData(new Item { Id=1, Name ="Lacoste T-Shirt", UserId = 1 , Desc="It's a description.",ShortDesc="It's a short description"});
        }
    }
}
