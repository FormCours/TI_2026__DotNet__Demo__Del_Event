using Demo_event.Models;

Personne p1 = new Personne("Donald", "Duck");

p1.OnFullOfBouffe += AfficherTropManger;
p1.OnNope += AfficherMessage;
p1.OnNope += (p, txt) => Console.WriteLine("Je ne mange pas de GRAINE !");

p1.Manger(new Repas(Repas.RepasEnum.Vegan));
p1.Manger(new Repas(Repas.RepasEnum.Mix));
p1.Manger(new Repas(Repas.RepasEnum.Vege));
p1.Manger(new Repas(Repas.RepasEnum.Carnivor));
p1.Manger(new Repas(Repas.RepasEnum.Mix));
p1.Manger(new Repas(Repas.RepasEnum.Vegan));
p1.Manger(new Repas(Repas.RepasEnum.Mix));
p1.Manger(new Repas(Repas.RepasEnum.Mix));

void AfficherTropManger(Personne p)
{
    Console.WriteLine($"{p.Prenom} a trop mangé !");
}
void AfficherMessage(Personne p, string message)
{
    Console.WriteLine($"{p.Prenom} dit : {message}");
}