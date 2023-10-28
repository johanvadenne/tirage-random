from random import randint

# FR: ouvre le fichier texte_ascii.txt en lecture
# EN: opens the text_ascii.txt file in read mode
fichier_ascii = open("texte_ascii.txt", "r+", encoding="utf-8")

# FR: lit le fichier et enregistre le texte
# EN: reads the file and saves the text
texte_ascii = fichier_ascii.read()

# FR: affiche le texte ascii pour la présentation
# EN: displays ascii text for presentation
print(texte_ascii)


# FR: ouvre le fichier utilisateur.txt en lecture
# EN: opens the utilisateur.txt file in read mode
fichier_utilisateur = open("utilisateur.txt", "r+", encoding="utf-8")

# FR: lit le fichier et enregistre les utilisateurs dans un tableau
# EN: opens user.txt file for reading
tab_utilisateur = fichier_utilisateur.read().split("\n")

while 1:
    # FR: attend une réponse de l'utilisateur
    # EN: reads the file and saves the users in an array
    reponse = input("- 'GO' pour faire un tirage\n- 'STOP' pour arrêter\n")

    # FR: si 'GO' faire un tirage
    # EN: waits for user response
    if reponse == "GO":
        # génère un nombre aléatoire
        # EN: if 'GO' do a draw
        utilisateur_random = randint(0, len(tab_utilisateur)-1)

        # FR: affiche l'utiilisateur
        # EN: displays user
        print(tab_utilisateur[utilisateur_random])

    # FR: si 'STOP' sortir de la boucle
    # EN: if 'STOP' exit the loop
    elif reponse == "STOP":
        break

# FR: la politesse tout de même
# EN: politeness all the same
print("merci, et à bientôt!")
