﻿// FR: lecture et récupération des textes des fichiers
// FR: reading and retrieving file texts
string texteAscii = File.ReadAllText(@".\texte_ascii.txt");
List<string> tab_utilisateur = new List<string>(File.ReadAllLines(@".\utilisateur.txt"));

// FR: affiche le texte ascii pour la présentation
// EN: displays ascii text for presentation
Console.WriteLine(texteAscii);

// init Random
Random aleatoire = new Random();

while(true)
{
    // FR: attend une réponse de l'utilisateur
    // EN: reads the file and saves the users in an array
    Console.WriteLine("- 'GO' pour faire un tirage\n- 'STOP' pour arrêter\n");
    string reponse = Console.ReadLine();

    // FR: si 'GO' faire un tirage
    // EN: if 'GO' do a draw
    if (reponse == "GO")
    {
        // FR: génère un nombre aléatoire
        // EN: generates a random number
        int entierRandom = aleatoire.Next(tab_utilisateur.Count);

        // FR: affiche l'utiilisateur
        // EN: displays user
        Console.WriteLine("\n"+tab_utilisateur[entierRandom]+"\n");

        // FR: retire l'utilisateur de la liste
        // EN: remove user from the list
        tab_utilisateur.RemoveAt(entierRandom);
    }
    // FR: si 'STOP' sortir de la boucle
    // EN: if 'STOP' exit the loop
    else if (reponse == "STOP")
    {
        break;
    }

    // FR: sortir si il n'y a plus d'utilisateur
    // EN: exit if no user left
    if (tab_utilisateur.Count == 0)
    {
        break;
    }
}
// FR: la politesse tout de même
// EN: politeness all the same
Console.WriteLine("merci, et à bientôt!");
Console.ReadLine();