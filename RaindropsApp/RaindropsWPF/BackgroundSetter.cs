using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaindropFunctions;

namespace RaindropsWPF
{
	public static class BackgroundSetter
	{
		public static Uri Background(string ppp)
		{
			return ppp switch
			{
				"Pling" 
					or "Plang" 
					or "Plong" => new Uri("backgrounds/cloudy.jpg", UriKind.Relative),
				"PlingPlang" 
					or "PlangPlong" 
					or "PlingPlong" => new Uri("backgrounds/rain.jpg", UriKind.Relative),
				"PlingPlangPlong" => new Uri("backgrounds/heavyrain.jpg", UriKind.Relative),
				_ => new Uri("backgrounds/nice.jpg", UriKind.Relative)
			};
		}
	}
}
