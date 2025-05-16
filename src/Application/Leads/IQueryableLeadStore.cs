// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Pipeline.Domain.Leads;

namespace Wangkanai.Pipeline.Application.Leads;

public interface IQueryableLeadStore : ILeadStore
{
	IQueryable<Lead> Leads { get; }
	List<Lead>       GetAll(CancellationToken cancellationToken);
	List<Lead>       GetAllByOfficerId(int    officerId, CancellationToken cancellationToken);
}
