double odds = 0.75;
Guy player = new Guy() { Name = "The Player", Cash = 100 };

Console.WriteLine("Welcome to the casino. The odds are 0.75");

while (player.Cash > 0)
{
    player.WriteMyInfo();
    Console.Write("How much do you want to bet: ");
    string? howMuch = Console.ReadLine();
    if (int.TryParse(howMuch, out int amount))
    {
        int pot = player.GiveCash(amount) * 2; ;
        if (pot > 0)
        {
            double randValue = Random.Shared.NextDouble();
            if (randValue > odds)
            {
                int winnings = pot;
                Console.WriteLine("You win " + winnings);
                player.ReceiveCash(winnings);
            }
            else
            {
                Console.WriteLine("Bad luck, you lose.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
Console.WriteLine("The House always wins.");


public class Guy
{
    public string? Name;
    public int Cash;

    public void WriteMyInfo()
    {
        Console.WriteLine(Name + " has " + Cash + " cash.");
    }

    public int GiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
            return 0;
        }
        if (amount > Cash)
        {
            Console.WriteLine(Name + " says: " + "I don't have enough cash to give you " + amount);
            return 0;
        }
        Cash -= amount;
        return amount;
    }

    public void ReceiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take");
        }
        else
        {
            Cash += amount;
        }
    }
}

