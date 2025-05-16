using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Wangkanai.Pipeline.Domain.Identity;

namespace Wangkanai.Pipeline.Data;

public class PipelineDbContext(DbContextOptions<PipelineDbContext> options) : IdentityDbContext<PipelineUser>(options)
{
}
