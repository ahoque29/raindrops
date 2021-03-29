namespace RaindropFunctions
{
	/// <summary>
	/// Static class that holds the PlingPlangPlong() Method
	/// </summary>
	public static class Raindrops
	{
		/// <summary>
		/// Static Method that takes an integer and returns a string based on the input.
		/// </summary>
		/// <param name="input">
		/// Integer input.
		/// </param>
		/// <returns>
		/// Pling if the integer is divisible by 3,
		/// Plang if the integer is divisible by 5,
		/// Plong if the integer is divisible by 7.
		/// Combinations are also possible
		///</returns>
		public static string PlingPlangPlong(int input)
		{
			if (input % 3 != 0
				&& input % 5 != 0
				&& input % 7 != 0)
			{
				return input.ToString();
			}

			var output = "";

			if (input % 3 == 0)
			{
				output += "Pling";
			}

			if (input % 5 == 0)
			{
				output += "Plang";
			}

			if (input % 7 == 0)
			{
				output += "Plong";
			}

			return output;
		}
	}
}