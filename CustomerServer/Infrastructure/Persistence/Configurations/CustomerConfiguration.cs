using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerServer.Infrastructure.Persistence.Configurations
{
    internal sealed class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(nameof(Customer));

            builder.HasKey(customer => customer.Id);

            builder.Property(customer => customer.Id).ValueGeneratedOnAdd();

            builder.Property(customer => customer.Name).HasMaxLength(64);

            builder.Property(customer => customer.Address).HasMaxLength(256);

            builder.Property(customer => customer.PhoneNumber).HasMaxLength(16);

            builder.Property(customer => customer.Country).HasMaxLength(32);

            builder.Property(customer => customer.City).HasMaxLength(32);
        }
    }
}