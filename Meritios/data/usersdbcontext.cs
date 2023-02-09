using Meritios.Moudels.Domain;
using Microsoft.EntityFrameworkCore;

namespace Meritios.data
{
	public class usersdbcontext : DbContext
    {
		public usersdbcontext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<users> _Users { get; set; }	
	}
}
