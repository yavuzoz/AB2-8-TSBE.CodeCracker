using System;
using Tsbe.CodeCracker;

namespace AB2_8_TSBE.CodeCracker
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bitte Passwort eingeben:");
			string password = Console.ReadLine();

			string targetHash = MD5Hash.GeneratePassword(password);

			Console.WriteLine($"Ihr Passwort als Hashcode ist: {targetHash}");
			Console.WriteLine("Bitte max Länge eingeben: ");
			int maxLength = int.Parse(Console.ReadLine());

			char[] allowedCharacters = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray(); 

			string crackedPassword = MD5Hash.CrackPassword(targetHash, maxLength, allowedCharacters);

			if (crackedPassword != null)
			{
				Console.WriteLine($"Cracked Password: {crackedPassword}");
			}
			else
			{
				Console.WriteLine("Password not cracked.");
			}
		}
	}
}
