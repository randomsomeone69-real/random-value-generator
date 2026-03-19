string ReturnSomething()
{
    string[] something = new string[] { "VHS", "S-VHS", "VHS-C", "D-VHS", "Betamax", "Video 2000" };
    Random alea = new Random(); // commande de génération de nombre aléatoire
    return something[alea.Next(6)]; //génére un nombre aléatoire, puis va chercher la valeur de la génération
}

string Duration()
{
    string[] something = new string[] { "SP", "LP", "EP/SLP", "VP (NTSC)" };
    Random alea = new Random(); // commande de génération de nombre aléatoire
    return something[alea.Next(4)]; //génére un nombre aléatoire, puis va chercher la valeur de la génération
}

void ShowDescriptor()
{
    Console.WriteLine($"The tape is a {ReturnSomething()} tape with a {Duration()} type.");
}

void Politeness()
{
    Console.WriteLine($"Program executed at {DateTime.Now}. Hello dear user!");
}

Politeness();
ShowDescriptor();