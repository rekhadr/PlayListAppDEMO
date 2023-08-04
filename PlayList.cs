using System;

namespace TestVagrantAssignment
{
	public class PlayList
	{
		public Song front, rear;
		int maxSongsCapacity, lengthOfPlayList;

		public PlayList(int maxSongsCapacity)
		{
			this.front = this.rear = null;
			this.maxSongsCapacity = maxSongsCapacity;
			this.lengthOfPlayList = 0;
		}


		// Method to add song to the playlist.
		public void AddSongToPlayList(string songName)
		{
			try
			{
				if (songName == null)
				{
					throw new NullReferenceException("Song is null");
				}

				if (this.maxSongsCapacity == this.lengthOfPlayList + 1)
					RemoveSongFromPlayList();

				Song song = new Song(songName);

				if (this.rear == null)
				{
					this.front = this.rear = song;
					return;
				}

				this.rear.next = song;
				this.rear = song;
				this.lengthOfPlayList += 1;
			}
			catch(Exception e)
            {
				Console.WriteLine("Song can not be null");
			}


		}

		public void RemoveSongFromPlayList()
		{
			if (this.front == null)
				return;

			this.front = this.front.next;

			if (this.front == null)
				this.rear = null;

			this.lengthOfPlayList -= 1;
		}

		public void ShowPlayList()
		{
			if (this.front == null)
				return;

			Song currentSong = this.front;

			Console.Write(currentSong.song + ", ");

			while (currentSong.next != null)
			{
				currentSong = currentSong.next;
				Console.Write(currentSong.song + ", ", "\n");

			}

		}

	}

}
