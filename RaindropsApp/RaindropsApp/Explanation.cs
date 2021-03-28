using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaindropFunctions
{
	public static class Explanation
	{
		public static HashSet<int> PrimeFactorisation(int n)
		{
			var primeFactors = new HashSet<int>();

			if (n == 0)
			{
				return primeFactors;
			}

			var a = Math.Abs(n);

			for (int i = 2; a != 1; i++)
			{
				if (a % i == 0)
				{
					primeFactors.Add(i);
					a /= i;
					i--;
				}
			}

			return primeFactors;
		}

		public static string Reasoning(int n)
		{
			var primeFactorString = string.Empty;

			foreach (var prime in PrimeFactorisation(n))
			{
				primeFactorString += $"{prime} ";
			}

			var reasoning = $"{n}'s prime factors are: {primeFactorString}hence, {Raindrops.PPP(n)}!";

			return reasoning;
		}
		
	}
}
