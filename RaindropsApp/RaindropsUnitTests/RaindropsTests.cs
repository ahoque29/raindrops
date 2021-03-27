using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RaindropFunctions;

namespace RaindropsUnitTests
{
	[TestFixture]
	[Parallelizable]
	public class RaindropsTests
	{
		[Test]
		public void WhenZeroIsPassed_Returns_PlingPlangPlong()
		{
			Assert.That(Raindrops.PlingPlangPlong(0), Is.EqualTo("PlingPlangPlong"));
		}

		[TestCase(3, "Pling")]
		[TestCase(-3, "Pling")]
		[TestCase(198, "Pling")]
		[TestCase(-24543, "Pling")]
		public void WhenAnIntegerDivisibleByThreeButNotFiveOrSevenIsPassed_Returns_Pling(int a, string expectedResult)
		{
			Assert.That(Raindrops.PlingPlangPlong(a), Is.EqualTo(expectedResult));
		}

		public void 
	}
}
