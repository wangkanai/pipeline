// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Domain;

namespace Wangkanai.Pipeline.Domain.Leads;

public class Lead : AuditableEntity<int>
{
	public string Firstname { get; set; }
	public string Lastname  { get; set; }
	public string Email     { get; set; }
	public string Phone     { get; set; }
}
