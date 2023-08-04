using System;
using TestVagrantAssignment;

public class UserPlayListApp
{
	public static void Main(String[] args)
	{
		InputFromUser input = new InputFromUser();

		Console.WriteLine("Enter the length of the playlist");
		int lengthOfPlayList = Convert.ToInt32(Console.ReadLine());
		input.GetInputFromUser(lengthOfPlayList);
			
	}
}

