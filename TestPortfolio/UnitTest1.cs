using Portfolio.Models;
using Portfolio.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace TestPortfolio
{
	[TestClass]
	public class UnitTest1
	{
		[HttpPost]
		public void CreatePlayer_Should_pass(string firstName)
		{
			var createPlayer = new SportsRosterModel();
			createPlayer.FirstName = firstName;
			createPlayer.LastName = "Wapo";
			createPlayer.Number = 1;
			createPlayer.Throws = "Right";
			createPlayer.Bats = "Switch";

			var results = (createPlayer);

			results.Should();
		}
	}
}