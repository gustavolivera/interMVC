using Microsoft.EntityFrameworkCore;

namespace interMVC
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options) : base(options) {}
		
		public DbSet<Chamado> Chamados { get; set; }
	}
}
