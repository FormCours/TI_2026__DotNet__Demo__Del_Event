namespace Demo_event.Models
{
    public class Repas
    {
        public enum RepasEnum
        {
            Mix,
            Vege,
            Carnivor,
            Vegan
        }

        public RepasEnum Contenu { get; private init; }

        public Repas(RepasEnum contenu)
        {
            Contenu = contenu;
        }
    }
}
