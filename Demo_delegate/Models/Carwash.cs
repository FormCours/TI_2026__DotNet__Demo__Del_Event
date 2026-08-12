
using System.Numerics;

namespace Demo_delegate.Models
{
    // ↓ Fonction qui ne renvoi rien et prend un objet "Voiture" en params
    public delegate void CarwashDelegate(Voiture v);

    public class Carwash
    {
        public CarwashDelegate? Del { get; set; }

        private void Preparer(Voiture v)
        {
            Console.WriteLine($"je prépare la voiture : {v.Plaque}");
        }
        private void Laver(Voiture v)
        {
            Console.WriteLine($"je lave la voiture : {v.Plaque}");
        }
        private void Secher(Voiture v)
        {
            Console.WriteLine($"je sèche la voiture : {v.Plaque}");
        }
        private void Finaliser(Voiture v)
        {
            Console.WriteLine($"je finalise la voiture : {v.Plaque}");
        }

        public void AjouterOption(int  option)
        {
            switch (option)
            {
                case 1:
                    Del += Preparer;
                    break;
                case 2:
                    Del += Laver;
                    break;
                case 3:
                    Del += Secher;
                    break;
                case 4:
                    Del += Finaliser;
                    break;
            }
        }

        public void Traiter(Voiture v)
        {
            // ↓ Déclanche les methodes contenu dans la variable
            Del?.Invoke(v);

            // ↓ On vide le delegate
            Del = null;
        }
    }
}
