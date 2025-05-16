// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Pipeline.Domain.Primitives;

namespace Wangkanai.Pipeline.Application.Modules;

public interface IModuleStore : IDisposable
{
	Task<Result<Module>>  CreateAsync(Module module, CancellationToken cancellationToken);
	Task<Result<Module>>  UpdateAsync(Module module, CancellationToken cancellationToken);
	Task<Result<string>>  DeleteAsync(Module module, CancellationToken cancellationToken);
	Task<Result<Module?>> GetByIdAsync(int   id,     CancellationToken cancellationToken);
}
