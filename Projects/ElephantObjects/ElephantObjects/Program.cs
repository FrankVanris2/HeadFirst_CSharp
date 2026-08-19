using ElephantObjects;

Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

while (true)
{
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int value))
    {
        Console.WriteLine("You Pressed " + value);
        if (value == 1)
        {
            Console.WriteLine("Calling lloyd.whoAmI()");
            lloyd.WhoAmI();
        }
        else if (value == 2)
        {
            Console.WriteLine("Calling lucinda.whoAmI()");
            lucinda.WhoAmI();
        }
        else if (value == 3)
        {
            Elephant temp = lloyd;
            lloyd = lucinda;
            lucinda = temp;
            Console.WriteLine("References have been swapped");
        } else if (value == 4) { 
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        } else if (value == 5)
        {
            lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
        }
        else
        {
            return;
        }
        Console.WriteLine();
    }
}
