// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Pipeline.Domain.Leads;
using Wangkanai.Pipeline.Domain.Primitives;

namespace Wangkanai.Pipeline.Application.Leads;

public interface ILeadStore : IDisposable
{
	Task<Result<Lead>>  CreateAsync(Lead lead, CancellationToken cancellationToken);
	Task<Result<Lead>>  UpdateAsync(Lead lead, CancellationToken cancellationToken);
	Task<Result<Lead>>  DeleteAsync(Lead lead, CancellationToken cancellationToken);
	Task<Result<Lead?>> GetByIdAsync(int id,   CancellationToken cancellationToken);
}
