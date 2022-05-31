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
            throw new NotImplementedException();
        }
    }
}
