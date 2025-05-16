using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Wangkanai.Pipeline.Data;

public class PipelineDbContext(DbContextOptions<PipelineDbContext> options) : IdentityDbContext<PipelineUser>(options)
{
}
