using System;

namespace RandomCardPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of cards You want!:");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Enter a Valid Number!!");

            }
        }
    }
}
