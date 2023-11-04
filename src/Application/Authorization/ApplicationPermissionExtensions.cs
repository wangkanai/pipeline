// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Pipeline.Authorization;
using Wangkanai.Extensions;

namespace Wangkanai.Pipeline.Application.Authorization;

public static class ApplicationPermissionExtensions
{
	public static ApplicationPermissions[] GetAll => EnumValues<ApplicationPermissions>.GetValues();
}