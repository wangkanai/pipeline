// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Pipeline.Domain.Leads;

namespace Wangkanai.Pipeline.Application.Leads;

public class LeadConfiguration : IEntityTypeConfiguration<Lead>
{
	public void Configure(EntityTypeBuilder<Lead> builder)
	{
		builder.Property(x => x.Firstname)
		       .IsUnicode()
		       .HasMaxLength(50)
		       .IsRequired();

		builder.Property(x => x.Lastname)
		       .IsUnicode()
		       .HasMaxLength(50)
		       .IsRequired();

		builder.Property(x => x.Email)
		       .HasMaxLength(50)
		       .IsRequired();

		builder.Property(x => x.Phone)
		       .HasConversion<PhoneAttribute>()
		       .IsRequired();

		builder.HasData();
	}
}
