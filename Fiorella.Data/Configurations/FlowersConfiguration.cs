using Fiorella.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Data.Configurations
{
    public class FlowersConfiguration : IEntityTypeConfiguration<Flowers>
    {
        public void Configure(EntityTypeBuilder<Flowers> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(20).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.CostPrice).IsRequired(true);
            builder.Property(x => x.SalePrice).IsRequired(true);
            builder.Property(x => x.CategoryId).IsRequired(true);
        }
    }
}
