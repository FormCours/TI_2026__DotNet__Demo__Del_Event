namespace Demo_event.Models
{
    public class Personne
    {
        public event Action<Personne>? OnFullOfBouffe = null;
        public event Action<Personne, string>? OnNope = null;

        private int Capacite = 5; 
        public string Prenom { get; set; }
        public string Nom { get; set; }

        public Personne(string prenom, string nom)
        {
            Prenom = prenom;
            Nom = nom;
        }

        public void Manger(Repas repas)
        {
            if(Capacite == 0)
            {
                OnFullOfBouffe?.Invoke(this);
                return;
            }

            if(repas.Contenu == Repas.RepasEnum.Vegan)
            {
                OnNope?.Invoke(this, "Je suis pas un lapin");
                return;
            }

            Capacite--;
        }
    }
}
