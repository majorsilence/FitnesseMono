using System;

namespace slim_example
{
	public class CreateShows
	{
		public String ProgramDate { get; set; }
		public String Name { get; set; }
		public String Episode { get; set; }
		public int Channel { get; set; }
		public String StartTime { get; set; }
		public int Duration { get; set; }
		public String LastId { get; set; }

		public CreateShows(string programDate)
		{
			ProgramDate = programDate;
		}

		public void Execute()
		{
			Console.WriteLine("Hi");
			LastId = string.Format("{0}:{1}", Name, Channel);
		}

		public String Id()
		{
			return LastId;
		}
	}
}

