using System;
using System.Linq;

namespace Hangman
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

				if (word.Contains(letter) && !(right.Contains(letter)))
				{
					right.Add(letter);
					Console.WriteLine("That letter was correct.");
					Console.Write("right letters: ");
					for (int i = 0; i < right.Count; i++)
					{
						Console.Write(right[i] + ", ");
					}
					Console.WriteLine();
					Console.Write("wrong letters: ");
					for (int i = 0; i < wrong.Count; i++)
					{
						Console.Write(wrong[i] + ", ");
					}
					Console.WriteLine();
				}
				else if (!(word.Contains(letter)) && !(wrong.Contains(letter)))
				{
					wrong.Add(letter);
					Console.WriteLine("That letter was incorrect.");
					Console.Write("right letters: ");
					for (int i = 0; i < right.Count; i++)
					{
						Console.Write(right[i] + ", ");
					}
					Console.WriteLine();
					Console.Write("wrong letters: ");
					for (int i = 0; i < wrong.Count; i++)
					{
						Console.Write(wrong[i] + ", ");
					}
					Console.WriteLine();
				} else
                {
					Console.WriteLine("That letter was already picked. Please try another one.");
                }

				if (right.Contains(word[0]) && right.Contains(word[1]) && right.Contains(word[2]) && right.Contains(word[3])) 
					{
					Console.WriteLine("Congradulations. You won!");
					break;
                }

					guesRemaining--;
				Console.WriteLine("You have : " + guesRemaining + " guesses remaining.");

			}
			Console.WriteLine("The word was: " + wordList[wordSelector]);
		}
	}
}