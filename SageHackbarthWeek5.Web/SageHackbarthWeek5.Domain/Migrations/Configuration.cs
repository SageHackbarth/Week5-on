using SageHackbarthWeek5.Domain.Entities;

namespace SageHackbarthWeek5.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SageHackbarthWeek5.Domain.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SageHackbarthWeek5.Domain.EmployeeContext context)
        {
	        context.Employees.AddOrUpdate(new Employee
	        {
		        EmplyeeId = Guid.Parse("3cc32149-988d-44d6-b091-66c0ff00e7be"),
		        Email = "steeelerfan69@gmail.com",
		        Name = "Sage Hackbarth",
		        Role = "Designer, creator, lead basket case, and everything else"
	        });

			context.People.AddOrUpdate(new Person
			{
				PersonId = Guid.Parse("4e5504db-5036-485f-b7c2-a709b0e01530"),
				FirstName = "Sage",
				LastName = "Hackbarth",
				Email = "steeelerfan69@gmail.com",
				DateCreated = DateTime.Today
			});

			context.HighScores.AddOrUpdate(new HighScore
			{
				HighScoreId = Guid.Parse("d7a2ed53-0e46-468e-aec5-4d43eb8b1a74"),
				Score = "10",
				DateAttained = DateTime.Today,
				PersonId = "4e5504db-5036-485f-b7c2-a709b0e01530"
			});
			context.HighScores.AddOrUpdate(new HighScore
			{
				HighScoreId = Guid.Parse("75ced61d-c963-4ba7-b6ea-f1e70274af51"),
				Score = "15",
				DateAttained = DateTime.Today,
				PersonId = "4e5504db-5036-485f-b7c2-a709b0e01530"
			});
			context.HighScores.AddOrUpdate(new HighScore
			{
				HighScoreId = Guid.Parse("2fcaddb4-2b52-48f0-8cc8-c47cf9bd59d3"),
				Score = "20",
				DateAttained = DateTime.Today,
				PersonId = "4e5504db-5036-485f-b7c2-a709b0e01530"
			});
			context.HighScores.AddOrUpdate(new HighScore
			{
				HighScoreId = Guid.Parse("2aa4402f-534a-4d29-8646-a3957644cb52"),
				Score = "25",
				DateAttained = DateTime.Today,
				PersonId = "4e5504db-5036-485f-b7c2-a709b0e01530"
			});
			context.HighScores.AddOrUpdate(new HighScore
			{
				HighScoreId = Guid.Parse("63d77ae0-bdf3-42ce-a21f-2565627d8732"),
				Score = "30",
				DateAttained = DateTime.Today,
				PersonId = "4e5504db-5036-485f-b7c2-a709b0e01530"
			});
		}
    }
}
