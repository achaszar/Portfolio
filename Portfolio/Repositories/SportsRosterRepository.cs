using Microsoft.EntityFrameworkCore;
using Portfolio.Controllers;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Repositories
{ 
	public class SportsRosterRepository
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Number { get; set; }
		public string Position { get; set; }
		public string Bats { get; set; }
		public string Throws { get; set; }
	}
}
