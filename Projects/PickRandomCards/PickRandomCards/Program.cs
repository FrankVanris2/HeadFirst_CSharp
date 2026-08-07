namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string? line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                string[] pickedCards = CardPicker.PickSomeCards(numberOfCards);
                foreach (string card in pickedCards)
                {
                    Console.WriteLine(card);
                }
            } else
            {
                Console.WriteLine("That is not a valid number.");
            }
        }
    }
}
