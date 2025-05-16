// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Pipeline.Application.Modules;

public interface IQueryableModuleStore : IModuleStore
{
	IQueryable<Module> Modules { get; }
}
