# FR: ouvre le fichier texte_ascii.txt en lecture
# EN: opens the text_ascii.txt file in read mode
fichier_ascii = open("texte_ascii.txt")

# FR: lit le fichier et enregistre le texte
# EN: reads the file and saves the text
texte_ascii = fichier_ascii.read

# FR: affiche le texte ascii pour la présentation
# EN: displays ascii text for presentation
puts texte_ascii

# FR: ouvre le fichier utilisateur.txt en lecture
# EN: opens the utilisateur.txt file in read mode
tab_utilisateur = open("utilisateur.txt").map(&:chomp)

# FR: lit le fichier et enregistre les utilisateurs dans un tableau
# EN: opens user.txt file for reading

while 1
    # FR: attend une réponse de l'utilisateur
    # EN: reads the file and saves the users in an array
    puts "- 'GO' pour faire un tirage\n- 'STOP' pour arrêter\n"
    reponse = gets.chomp

    # FR: si 'GO' faire un tirage
    # EN: waits for user response
    if reponse == "GO"
        # génère un nombre aléatoire
        # EN: if 'GO' do a draw
        utilisateur_random = rand(tab_utilisateur.length)

        # FR: affiche l'utiilisateur
        # EN: displays user
        puts tab_utilisateur[utilisateur_random]

    # FR: si 'STOP' sortir de la boucle
    # EN: if 'STOP' exit the loop
    elsif reponse == "STOP"
        break
    end
end
# FR: la politesse tout de même
# EN: politeness all the same
puts "merci, et à bientôt!"
