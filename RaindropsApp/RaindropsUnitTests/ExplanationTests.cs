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

		#endregion

		#region Reasoning Tests



		#endregion
	}
}
