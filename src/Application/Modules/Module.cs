// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Domain;

namespace Wangkanai.Pipeline.Application.Modules;

public sealed class Module : Entity<int>
{
	public required string Name { get; set; }
}
