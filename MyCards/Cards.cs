namespace MyCards
{
    public class Cards
    {
        public string Suit { get; }
        public string Value { get; }
        public Cards(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }
    }
}
