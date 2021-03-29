using System;

namespace RaindropsWPF
{
	public static class BackgroundSetter
	{
		public static Uri Background(string ppp)
		{
			return ppp switch
			{
				"Pling" or "Plang" or "Plong" => new Uri("https://i.imgur.com/6TfMjns.jpg"),
				"PlingPlang" or "PlangPlong" or "PlingPlong" => new Uri("https://i.imgur.com/klDmJFL.jpg"),
				"PlingPlangPlong" => new Uri("https://i.imgur.com/ykDzt4s.jpg"),
				_ => new Uri(@"https://i.imgur.com/FDk2yEt.jpg")
			};
		}
	}
}