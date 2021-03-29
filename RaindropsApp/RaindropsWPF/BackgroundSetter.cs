using System;

namespace RaindropsWPF
{
	/// <summary>
	/// Static class that sets the background of the front end
	/// </summary>
	public static class BackgroundSetter
	{
		/// <summary>
		/// Static method that takes in a plingplangplong (string) input
		/// </summary>
		/// <param name="plingPlangPlong">
		/// String input
		/// </param>
		/// <returns>
		/// Image Uri
		/// </returns>
		public static Uri Background(string plingPlangPlong)
		{
			return plingPlangPlong switch
			{
				// cloudy
				"Pling" or "Plang" or "Plong" => new Uri("https://i.imgur.com/6TfMjns.jpg"),
				// rain
				"PlingPlang" or "PlangPlong" or "PlingPlong" => new Uri("https://i.imgur.com/klDmJFL.jpg"),
				// heavy rain
				"PlingPlangPlong" => new Uri("https://i.imgur.com/ykDzt4s.jpg"),
				_ => new Uri(@"https://i.imgur.com/FDk2yEt.jpg")
			};
		}
	}
}