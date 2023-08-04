using System;
using System.Collections.Generic;

namespace TestVagrantAssignment
{
	public class UserSongMap
	{
		Dictionary<string, PlayList> userSongPair = new Dictionary<string, PlayList>();
		public void AddUser(string userName, int lengthOfPlaylist)
		{			
			try
			{
				if (!userSongPair.ContainsKey(userName))
				{

					PlayList playList = new PlayList(lengthOfPlaylist);
					userSongPair.Add(userName, playList);
					Console.WriteLine("User created successfully with username " + userName);
				}
				else
				{
					Console.WriteLine("User already exists");
				}
			}
		
			catch (Exception)
			{
				Console.WriteLine("User already exists");
			}

		}

		public PlayList GetUserPlayList(string userName)
		{
			try
			{
				
				if (userSongPair.ContainsKey(userName))
				{
					return userSongPair[userName];
				}
			}
			catch (Exception e)
            {
				Console.WriteLine("User already exists");
            }
			return null;
		}

		public void UserSongPlayList(string userName)
		{
			
			PlayList playList = GetUserPlayList(userName);
			if (playList == null)
			{
				Console.WriteLine("User not exists, Please enter correct username");
			}
			else
			{
				while (true)
				{
					Console.WriteLine("\n\nHi " + userName + "!!!!, Welcome , Please choose your option");
					Console.WriteLine("1.Play new Song" );
					Console.WriteLine("2.Current PlayList" );
					Console.WriteLine("3.Exit from PlayList ");

					int choice = Convert.ToInt32(Console.ReadLine());

					switch (choice)
					{
						case 1:
							Console.WriteLine("\nEnter the song to play:");
							string songName = Console.ReadLine();
							playList.AddSongToPlayList(songName);
							Console.Write("\nCurrent Playlist of" + " " + userName + " " + "is :");
							playList.ShowPlayList();
							break;

						case 2:
							Console.Write("\nCurrent Playlist of the user" + " " + userName + " " + "is :\n");
							playList.ShowPlayList();
							return;

						default:
							Console.WriteLine("\nExiting from PlayList....");
							return;
					}
				}
			}
		}
	}

}
