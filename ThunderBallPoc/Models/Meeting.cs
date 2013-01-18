using System;

namespace ThunderBallPoc.Models
{
	public class Meeting
	{
		public string Topic { get; set; }

		public string Location { get; set; }

		public DateTime Date { get; set; }

		public string Description { get; set; }

		public string Speaker { get; set; }
	}
}