namespace RaindropFunctions
{
	public static class Raindrops
	{
		public static string PPP(int n)
		{
			if (n % 3 != 0
				&& n % 5 != 0
				&& n % 7 != 0)
			{
				return n.ToString();
			}

			var output = "";

			if (n % 3 == 0)
			{
				output += "Pling";
			}

			if (n % 5 == 0)
			{
				output += "Plang";
			}

			if (n % 7 == 0)
			{
				output += "Plong";
			}

			return output;
		}
	}
}