using NUnit.Framework;
using RaindropFunctions;
using System;
using System.Collections.Generic;

namespace RaindropsUnitTests
{
	[TestFixture]
	[Parallelizable]
	public class ExplanationTests
	{
		#region Prime Factorisation Tests

		[Test]
		public void WhenZeroIsFactorised_ReturnsEmptyHashset()
		{
			var result = Explanation.PrimeFactorisation(0);
			var expectedResult = new HashSet<int>();

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[Test]
		public void WhenOneIsFactorised_ReturnsEmptyHashset()
		{
			var result = Explanation.PrimeFactorisation(1);
			var expectedResult = new HashSet<int>();

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[Test]
		public void WhenSixIsFactorised_ReturnsTwoAndThree()
		{
			var result = Explanation.PrimeFactorisation(6);
			var expectedResult = new HashSet<int>
			{
				2, 3
			};

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[Test]
		public void WhenBigChunkyPositiveCompositeIntegerIsFactorised_ReturnsHashsetOfItsPrimeFactors()
		{
			var result = Explanation.PrimeFactorisation(510510);
			var expectedResult = new HashSet<int>
			{
				2, 3, 5, 7, 11, 13, 17
			};

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[Test]
		public void WhenEvenChunkierNegativeIntegerIsFactorised_ReturnsHashsetOfItsPrimeFactors()
		{
			var result = Explanation.PrimeFactorisation(-9699690);
			var expectedResult = new HashSet<int>
			{
				2, 3, 5, 7, 11, 13, 17, 19
			};

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[TestCase(2)]
		[TestCase(3)]
		[TestCase(5)]
		[TestCase(7)]
		[TestCase(101)]
		[TestCase(-103)]
		[TestCase(-7919)]
		public void WhenAPrimeNumberIsFactorised_ReturnsHashSetWithThatNumber(int prime)
		{
			var result = Explanation.PrimeFactorisation(prime);
			var expectedResult = new HashSet<int>
			{
				Math.Abs(prime)
			};

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		#endregion Prime Factorisation Tests

		#region Reasoning Tests

		[Test]
		public void WhenZeroIsPassed_ReturnsCorrectReasoning()
		{
			var result = Explanation.Reasoning(0);
			var expectedResult = "0 is divisible by everything! Hence PlingPlangPlong!";

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[Test]
		public void WhenSixIsPassed_ReturnsCorrectReasoning()
		{
			var result = Explanation.Reasoning(6);
			var expectedResult = "6's prime factors are: 2, 3, hence, Pling!";

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[TestCase(1, "1's prime factors are: hence, 1!")]
		[TestCase(2, "2's prime factors are: 2, hence, 2!")]
		[TestCase(3, "3's prime factors are: 3, hence, Pling!")]
		[TestCase(5, "5's prime factors are: 5, hence, Plang!")]
		[TestCase(6, "6's prime factors are: 2, 3, hence, Pling!")]
		[TestCase(7, "7's prime factors are: 7, hence, Plong!")]
		[TestCase(10, "10's prime factors are: 2, 5, hence, Plang!")]
		[TestCase(14, "14's prime factors are: 2, 7, hence, Plong!")]
		[TestCase(15, "15's prime factors are: 3, 5, hence, PlingPlang!")]
		[TestCase(21, "21's prime factors are: 3, 7, hence, PlingPlong!")]
		[TestCase(35, "35's prime factors are: 5, 7, hence, PlangPlong!")]
		[TestCase(105, "105's prime factors are: 3, 5, 7, hence, PlingPlangPlong!")]
		public void WhenANonZeroPositiveIntegerIsPassed_ReturnsCorrectReasoning(int input, string reasoning)
		{
			var result = Explanation.Reasoning(input);
			Assert.That(result, Is.EqualTo(reasoning));
		}

		[TestCase(-1, "-1's prime factors are: hence, -1!")]
		[TestCase(-2, "-2's prime factors are: 2, hence, -2!")]
		[TestCase(-3, "-3's prime factors are: 3, hence, Pling!")]
		[TestCase(-5, "-5's prime factors are: 5, hence, Plang!")]
		[TestCase(-6, "-6's prime factors are: 2, 3, hence, Pling!")]
		[TestCase(-7, "-7's prime factors are: 7, hence, Plong!")]
		[TestCase(-10, "-10's prime factors are: 2, 5, hence, Plang!")]
		[TestCase(-14, "-14's prime factors are: 2, 7, hence, Plong!")]
		[TestCase(-15, "-15's prime factors are: 3, 5, hence, PlingPlang!")]
		[TestCase(-21, "-21's prime factors are: 3, 7, hence, PlingPlong!")]
		[TestCase(-35, "-35's prime factors are: 5, 7, hence, PlangPlong!")]
		[TestCase(-105, "-105's prime factors are: 3, 5, 7, hence, PlingPlangPlong!")]
		public void WhenANonZeroNegativeIntegerIsPassed_ReturnsCorrectReasoning(int input, string reasoning)
		{
			var result = Explanation.Reasoning(input);
			Assert.That(result, Is.EqualTo(reasoning));
		}

		#endregion Reasoning Tests
	}
}