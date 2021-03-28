using NUnit.Framework;
using RaindropFunctions;

namespace RaindropsUnitTests
{
	[TestFixture]
	[Parallelizable]
	public class RaindropsTests
	{
		[Test]
		public void WhenZero_Returns_PlingPlangPlong()
		{
			Assert.That(Raindrops.PPP(0), Is.EqualTo("PlingPlangPlong"));
		}

		[TestCase(1, "1")]
		[TestCase(2, "2")]
		[TestCase(22, "22")]
		public void WhenAPositiveIntergetIsPassedThatIsNotDivisibleByThreeFiveOrSeven_ReturnsInteger(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(-1, "-1")]
		[TestCase(-2, "-2")]
		[TestCase(-2266, "-2266")]
		public void WhenANegativeIntergetIsPassedThatIsNotDivisibleByThreeFiveOrSeven_ReturnsInteger(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(3, "Pling")]
		[TestCase(9, "Pling")]
		[TestCase(66, "Pling")]
		public void WhenAPositiveIntegerDivisibleByThreeButNotFiveSevenIsPassed_Returns_Pling(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(-3, "Pling")]
		[TestCase(-9, "Pling")]
		[TestCase(-6798, "Pling")]
		public void WhenANegativeIntegerDivisibleByThreeButNotFiveSevenIsPassed_Returns_Pling(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(5, "Plang")]
		[TestCase(25, "Plang")]
		[TestCase(110, "Plang")]
		public void WhenAPositiveIntegerDivisibleByFiveButNotThreeOrSeven_Returns_Plang(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(-5, "Plang")]
		[TestCase(-25, "Plang")]
		[TestCase(-11330, "Plang")]
		public void WhenANegativeIntegerDivisibleByFiveButNotThreeOrSeven_Returns_Plang(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(7, "Plong")]
		[TestCase(49, "Plong")]
		[TestCase(154, "Plong")]
		public void WhenAPositiveIntegerDivisibleBySevenButNotThreeOrFive_Returns_Plong(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(-7, "Plong")]
		[TestCase(-49, "Plong")]
		[TestCase(-15862, "Plong")]
		public void WhenANegativeIntegerDivisibleBySevenButNotThreeOrFive_Returns_Plong(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(15, "PlingPlang")]
		[TestCase(225, "PlingPlang")]
		[TestCase(330, "PlingPlang")]
		public void WhenAPositiveIntegerDivisibleByThreeAndFiveButNotSeven_Returns_PlingPlang(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(-15, "PlingPlang")]
		[TestCase(-225, "PlingPlang")]
		[TestCase(-33990, "PlingPlang")]
		public void WhenANegativeIntegerDivisibleByThreeAndFiveButNotSeven_Returns_PlingPlang(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(35, "PlangPlong")]
		[TestCase(1225, "PlangPlong")]
		[TestCase(770, "PlangPlong")]
		public void WhenAPositiveIntegerDivisibleByFiveAndSevenButNotThree_Returns_PlangPlong(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(-35, "PlangPlong")]
		[TestCase(-1225, "PlangPlong")]
		[TestCase(-79310, "PlangPlong")]
		public void WhenANegativeIntegerDivisibleByFiveAndSevenButNotThree_Returns_PlangPlong(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(21, "PlingPlong")]
		[TestCase(441, "PlingPlong")]
		[TestCase(462, "PlingPlong")]
		public void WhenAPositiveIntegerDivisibleByThreeAndSevenButNotFive_Returns_PlingPlong(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(-21, "PlingPlong")]
		[TestCase(-47586, "PlingPlong")]
		public void WhenANegativeIntegerDivisibleByThreeAndSevenButNotFive_Returns_PlingPlong(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(105, "PlingPlangPlong")]
		[TestCase(11025, "PlingPlangPlong")]
		[TestCase(2310, "PlingPlangPlong")]
		public void WhenAPositiveIntegerDivisibleByThreeFiveAndSeven_Returns_PlingPlangPlong(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}

		[TestCase(-105, "PlingPlangPlong")]
		[TestCase(-11025, "PlingPlangPlong")]
		[TestCase(-237930, "PlingPlangPlong")]
		public void WhenANegativeIntegerDivisibleByThreeFiveAndSeven_Returns_PlingPlangPlong(int input, string expectedOutput)
		{
			Assert.That(Raindrops.PPP(input), Is.EqualTo(expectedOutput));
		}
	}
}