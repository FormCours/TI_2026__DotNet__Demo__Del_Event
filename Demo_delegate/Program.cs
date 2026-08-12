using Demo_delegate.Models;

Carwash carwash = new Carwash();
Voiture v1 = new Voiture("2 ABC 123");
Voiture v2 = new Voiture("3 ZXY 987");
Voiture v3 = new Voiture("J@CKY");
Voiture v4 = new Voiture("R0b€rt0");

Console.WriteLine("--------------------");
carwash.AjouterOption(1);
carwash.AjouterOption(2);
carwash.AjouterOption(2);
carwash.AjouterOption(3);
carwash.AjouterOption(4);
carwash.Traiter(v1);

Console.WriteLine("--------------------");
carwash.AjouterOption(2);
carwash.Del += (Voiture v) =>
{
    Console.WriteLine("je lave la voiture avec une éponge durant 30 minutes");
};
carwash.AjouterOption(4);
carwash.Traiter(v2);

Console.WriteLine("--------------------");
carwash.Traiter(v3);

Console.WriteLine("--------------------");
carwash.AjouterOption(1);
carwash.AjouterOption(2);
carwash.AjouterOption(4);
carwash.Del(v4);