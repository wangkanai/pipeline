﻿// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Pipeline.Models;

namespace Wangkanai.Pipeline.Infrastructure.Persistence.Configurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
	public void Configure(EntityTypeBuilder<Brand> builder)
	{
		builder.Property(brand => brand.Name)
		       .HasMaxLength(50)
		       .IsRequired();
	}
}