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
    internal class ItemKeyConfiguration : IEntityTypeConfiguration<ItemKey>
    {
        public void Configure(EntityTypeBuilder<ItemKey> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdentityKey).IsRequired();
            builder.Property(x => x.ItemId).IsRequired();
            builder.Property(x => x.Type).IsRequired();
        }
    }
}
