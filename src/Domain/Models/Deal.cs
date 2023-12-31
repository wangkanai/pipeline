﻿// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Pipeline.ValueObjects;
using Wangkanai.Domain;

namespace Wangkanai.Pipeline.Models;

public class Deal : AuditableEntity<int>
{
	public string?       Title        { get; set; }
	public string?       Description  { get; set; }
	public DateOnly?     Expended     { get; set; }
	public Stage         Stage        { get; set; }
	public DealTag?      Tag          { get; set; }
	public decimal       Value        { get; set; }
	public Currency?     Currency     { get; set; }
	public Organization? Organization { get; set; }
	public Contact?      Contact      { get; set; }
}

public class DealTag : AuditableEntity<int>
{
	public string Title { get; set; }
	public Color  Color { get; set; }
}