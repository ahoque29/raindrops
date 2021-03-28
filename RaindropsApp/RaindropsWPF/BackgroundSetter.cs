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
		public static string Background(string ppp)
		{
			return ppp switch
			{
				"Pling" 
					or "Plang" 
					or "Plong" => "Cloudy",
				"PlingPlang" 
					or "PlangPlong" 
					or "PlingPlong" => "Rainy",
				"PlingPlangPlong" => "Heavy Rain",
				_ => "Nice",
			};
		}
	}
}
