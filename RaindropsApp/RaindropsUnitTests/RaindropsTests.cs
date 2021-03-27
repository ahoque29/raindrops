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
		public void WhenZeroIsPassed_ReturnsPlingPlangPlong()
		{
			Assert.That(Raindrops.PlingPlangPlong(0), Is.EqualTo("PlingPlangPlong"));
		}
	}
}
