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
    internal class ItemMediaConfiguration : IEntityTypeConfiguration<ItemMedia>
    {
        public void Configure(EntityTypeBuilder<ItemMedia> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.File).IsRequired().HasMaxLength(128);
            builder.Property(x => x.ItemId).IsRequired();
            builder.Property(x => x.Type).IsRequired();

        }
    }
}
