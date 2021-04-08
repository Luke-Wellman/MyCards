using System;

namespace MyCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            bool Finished = false;
            while (deck.isEmpty() == Finished)
            {
                Console.WriteLine("Type d for deal\nType q to exit program");
                string input = Console.ReadLine();
                if (input == "d") { deck.Deal(); }
                else if (input == "q") { Finished = true; }
                else { Console.WriteLine("Please choose a valid option!"); }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
