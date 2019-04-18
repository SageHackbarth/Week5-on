using System;
using System.ComponentModel.DataAnnotations;

namespace SageHackbarthWeek5.Domain.Entities
{
	public class HighScore
	{
		[Key]
		public Guid HighScoreId { get; set; }
		public string PersonId { get; set; }
		public string Score { get; set; }
		public DateTime DateAttained { get; set; }
	}
}
