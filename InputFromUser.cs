using System;
using System.Collections.Generic;
using System.Text;

namespace TestVagrantAssignment
{
	public class InputFromUser
	{
		public void GetInputFromUser(int lengthOfPlayList)
		{
			UserSongMap userSongMap = new UserSongMap();

			try
			{ 
	
				while (true)
				{
					Console.WriteLine("\nEnter the choice !!!!");
					Console.WriteLine("1. New User ");
					Console.WriteLine("2. Existing User");
					Console.WriteLine("3. Exit ");

					int choice = Convert.ToInt32(Console.ReadLine());

					PlayList userPlaylist = null;
					switch (choice)
					{
						case 1:
							Console.WriteLine("\nEnter user name");
							string userName = Console.ReadLine();
							userSongMap.AddUser(userName, lengthOfPlayList);
							userSongMap.UserSongPlayList(userName);
							break;
						case 2:
							Console.WriteLine("\nEnter user name");
							string existingUserName = Console.ReadLine();
							userSongMap.UserSongPlayList(existingUserName);
							return;
						default:
							Console.WriteLine("\nExiting ....");
							return;
					}

				}
			}
			catch (Exception)
            {
				Console.WriteLine("Invalid choice");
            }

		}
	}
}

