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

			var a = n;

			for (int i = 0; a != 1; i++)
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
	}
}
