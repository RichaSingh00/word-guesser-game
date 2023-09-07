using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuesserGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to planets word guessing game.");
            Console.WriteLine("Let's understand the rules of the game.");
            Console.WriteLine("1. Guess the letters to form the given word.");
            Console.WriteLine("2. You have 6 lives to guess the word.");
            Console.WriteLine("3. After each wrong wrong guess, you lose a life. After loosing all the" +
                "lives you'll have to start agian.");
            Console.WriteLine("Try to guess the word within the lives, all the best. Let's begin!");

            string[] words = { "earth", "neptune", "uranus", "saturn", "mars", "venus" };
            string wordToGuess = GetRandomWord(words);
            char[] guessWord = new char[wordToGuess.Length];
            int lives = 6;

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                guessWord[i] = '_';
            }
            while (true)
            {
                Console.WriteLine("Guess the word: " + new string(guessWord));
                Console.WriteLine("Total lives left: " + lives);
                Console.WriteLine("Guess a letter: ");
                char input=Convert.ToChar(Console.ReadKey().KeyChar);
                char guess = input;
                Console.WriteLine();

                bool tally = false;
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess) //if the guess is matching the og word
                    {
                        guessWord[i] = guess;
                        tally = true;
                    }
                }
                if (!tally)
                {
                    lives--;
                    Console.WriteLine("Wrong guess, please guess again!");
                }
                if (new string(guessWord) == wordToGuess)
                {
                    Console.WriteLine("Bingo! You guessed the word!!");
                    break;
                }
                if (lives == 0)
                {
                    Console.WriteLine("0 remaining lives! The word was: " + wordToGuess);
                    break;
                }
            }
        }
            static string GetRandomWord(string[] words)
            {
                Random random = new Random();
                int index = random.Next(words.Length);
                return words[index];
            }
        }
    }

            