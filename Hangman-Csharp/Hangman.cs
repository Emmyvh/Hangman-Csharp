using System;
using System.Linq;

namespace Hangman_Csharp
{
    public class Hangman
    {
		private static void Main()
		{
			List<char> wrong = new List<char>();
			List<char> right = new List<char>();
			int guesRemaining = 10;


			Console.WriteLine("Welcome to a game of hangman.");
			Console.WriteLine("You play this game by guessing letters of a word.");
			Console.WriteLine("If you guess all letters of the word right within 10 tries you win.");
			Console.WriteLine("If you take more than 10 tries you lose.");

			string[] wordList = {
			"next", "word", "chat", "head", "read", "flow", "dice", "duck"
		};

			Random randNum = new Random();
			int wordSelector = randNum.Next(0, 8);

			List<char> word = wordList[wordSelector].ToList();

			while (guesRemaining > 0)
			{
				Console.WriteLine("Guess a letter.");
				string input = Console.ReadLine();
				char letter = input.ToCharArray()[0];

				if (word.Contains(letter))
				{
					right.Add(letter);
					Console.WriteLine("That letter was correct.");
					Console.WriteLine("right letters: " + right);
					Console.WriteLine("wrong letters: " + wrong);
				}
				else
				{
					wrong.Add(letter);
					Console.WriteLine("That letter was incorrect.");
					Console.WriteLine("right letters: " + right);
					Console.WriteLine("wrong letters: " + wrong);
				}

				guesRemaining--;
				Console.WriteLine(guesRemaining);

			}
		}
	}
}