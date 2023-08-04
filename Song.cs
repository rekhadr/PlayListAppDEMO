using System;

namespace TestVagrantAssignment
{
	public class Song
	{
		public string song;
		public Song next;

		public Song(string song)
		{
			this.song = song;
			this.next = null;
		}
	}

}
