string ReturnSomething()
{
    string[] something = new string[] { "VHS", "S-VHS", "VHS-C", "D-VHS", "Betamax" };
    Random alea = new Random(); // commande de génération de nombre aléatoire
    return something[alea.Next(5)]; //génére un nombre aléatoire, puis va chercher la valeur de la génération
}

string Duration()
{
    string[] something = new string[] { "SP", "LP", "EP/SLP", "VP (NTSC)" };
    Random alea = new Random(); // commande de génération de nombre aléatoire
    return something[alea.Next(4)]; //génére un nombre aléatoire, puis va chercher la valeur de la génération
}

Console.WriteLine(ReturnSomething());
Console.WriteLine(Duration());