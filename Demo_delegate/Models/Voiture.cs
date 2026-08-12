namespace Demo_delegate.Models
{
    public class Voiture
    {
        public string Plaque { get; private init; }

        public Voiture(string plaque)
        {
            Plaque = plaque;
        }
    }
}
