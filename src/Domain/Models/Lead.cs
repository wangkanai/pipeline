// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Pipeline.ValueObjects;
using Wangkanai.Domain;

namespace Wangkanai.Pipeline.Models;

public class Lead : AuditableEntity<int>
{
	public string?       Title        { get; set; }
	public DateOnly?     Expended     { get; set; }
	public decimal       Value        { get; set; }
	public Currency      Currency     { get; set; }
	public Organization? Organization { get; set; }
	public Contact?      Contact      { get; set; }
}

public class LeadTag : AuditableEntity<int>
{
	public string? Title { get; set; }
	public Color   Color { get; set; }
}