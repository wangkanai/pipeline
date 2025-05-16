// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Microsoft.EntityFrameworkCore;

using Wangkanai.Pipeline.Application.Leads;
using Wangkanai.Pipeline.Domain.Leads;
using Wangkanai.Pipeline.Domain.Primitives;

namespace Wangkanai.Pipeline.Infrastructure.Leads;

public class LeadStore<TContext>(TContext context) : IQueryableLeadStore, IDisposable
	where TContext : DbContext
{
	public IQueryable<Lead> Leads { get; }

	public List<Lead> GetAll(CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public List<Lead> GetAllByOfficerId(int officerId, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<Lead>> CreateAsync(Lead lead, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<Lead>> UpdateAsync(Lead lead, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<Lead>> DeleteAsync(Lead lead, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<Lead?>> GetByIdAsync(int id, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public void Dispose()
	{
		throw new NotImplementedException();
	}
}
