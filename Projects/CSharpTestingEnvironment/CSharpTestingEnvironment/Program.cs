Card aceOfSpades = new Card("Ace", "Spades");
Console.WriteLine(aceOfSpades.Name);

enum Suits
{
    Diamonds,
    Clubs,
    Hearts,
    Spades,
}
class Card(string value, string suit)
{
    public string Value { get { return value; } }
    public string Suit { get { return suit; } }
    public string Name { get { return $"{Value} of {Suit}"; } }
}