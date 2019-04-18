using SageHackbarthWeek5.Domain.Entities;
using System.Data.Entity;

namespace SageHackbarthWeek5.Domain
{
	public class EmployeeContext : DbContext
	{
		public DbSet<Employee> Employees { get; set; }
		public DbSet<HighScore> HighScores { get; set; }
		public DbSet<Person> People { get; set; }
	}
}
