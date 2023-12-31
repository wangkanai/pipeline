// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Domain;

namespace Wangkanai.Pipeline.Models;

public class Brand : AuditableEntity<int>
{
	public string        Name        { get; set; }
	public string?       Description { get; set; }
	public List<Product> Products    { get; set; }
}