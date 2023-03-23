using FluentAssertions;
using Portfolio.Models;
using Portfolio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestPortfolio
{
	public class SportsRosterTest
	{
		private readonly SportsRosterRepository _repo;

		SportsRosterTest()
		{
			_repo = new SportsRosterRepository();
		}

		[Theory]
		[InlineData("This should create a player roster table")]
		public async void CreatePlayer_Should_Pass(string firstName)
		{
			var createModel = new SportsRosterModel
			{
				FirstName = firstName,
				LastName = "JohnnyBats",
				Number = 37,
				Bats = "Left",
				Throws = "Right"
			};
			var result = _repo.Create(createModel);

			result.Should().NotBeNull();
		}

	}		
}
