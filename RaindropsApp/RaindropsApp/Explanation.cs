using System;
using System.Collections.Generic;

namespace RaindropFunctions
{
	/// <summary>
	/// Static class that holds methods for the explanation part of the front end
	/// </summary>
	public static class Explanation
	{
		/// <summary>
		/// Static Method that takes in an integer and returns a HashSet of it's prime factors
		/// </summary>
		/// <param name="input">
		/// Integer input
		/// </param>
		/// <returns>
		/// HashSet of prime factors
		/// </returns>
		public static HashSet<int> PrimeFactorisation(int input)
		{
			var primeFactors = new HashSet<int>();

			if (input == 0)
			{
				return primeFactors;
			}

			var intermediate = Math.Abs(input);

			// computes and adds prime factors by repeated division
			for (int i = 2; intermediate != 1; i++)
			{
				if (intermediate % i == 0)
				{
					primeFactors.Add(i);
					intermediate /= i;
					i--;
				}
			}

			return primeFactors;
		}

		/// <summary>
		/// Static method that returns the explanation text for the front end
		/// </summary>
		/// <param name="n">
		/// Integer input
		/// </param>
		/// <returns></returns>
		public static string Reasoning(int n)
		{
			if (n == 0)
			{
				return $"0 is divisible by everything! Hence {Raindrops.PlingPlangPlong(n)}!";
			}

			var primeFactorString = string.Empty;

			foreach (var prime in PrimeFactorisation(n))
			{
				primeFactorString += $"{prime}, ";
			}

			var reasoning = $"{n}'s prime factors are: {primeFactorString}hence, {Raindrops.PlingPlangPlong(n)}!";

			return reasoning;
		}
	}
}