// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Pipeline.Models;

namespace Wangkanai.Pipeline.Infrastructure.Persistence.Configurations;

public class DealConfiguration : IEntityTypeConfiguration<Deal>
{
	public void Configure(EntityTypeBuilder<Deal> builder)
	{
		builder.Property(deal => deal.Value)
		       .HasPrecision(9, 2);
	}
}