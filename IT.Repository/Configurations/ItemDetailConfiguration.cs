using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IT.Repository.Configurations
{
    internal class ItemDetailConfiguration : IEntityTypeConfiguration<ItemDetail>
    {
        public void Configure(EntityTypeBuilder<ItemDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Lang).IsRequired();
            builder.Property(x => x.Json).IsRequired();
            builder.Property(x => x.ItemID).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
          
        }
    }
}
