Guy joe = new Guy();
joe.Name = "Joe";
joe.Cash = 50;

Guy bob = new Guy();
bob.Name = "Bob";
bob.Cash = 100;

while (true)
{
    joe.WriteMyInfo();
    bob.WriteMyInfo();

    Console.WriteLine("Enter an amount: ");
    string? howMuch = Console.ReadLine();
    if (howMuch == "") return;

    if (int.TryParse(howMuch, out int amount))
    {
        Console.Write("Who should give the cash: ");
        string? whichGuy = Console.ReadLine();
        if (whichGuy == "Joe")
        {
            bob.ReceiveCash(joe.GiveCash(amount));
        }
        else if (whichGuy == "Bob")
        {
            joe.ReceiveCash(bob.GiveCash(amount));
        }
        else
        {
            Console.WriteLine("Please enter 'Joe' or 'Bob'");
        }
    }
    else
    {
        Console.WriteLine("Please enter an amount (or a blank line to exit).");
    }
}


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