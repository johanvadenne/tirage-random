from random import randint
import tkinter as tk

# FR: ouvre le fichier texte_ascii.txt en lecture
# EN: opens the text_ascii.txt file in read mode
fichier_utilisateur = open("utilisateur.txt", "r", encoding="utf-8")

# FR: lit le fichier et enregistre le texte
# EN: reads the file and saves the text
tab_utilisateur = fichier_utilisateur.readlines()
fichier_utilisateur.close()

# FR: Fonction de défilement du texte
# EN: Function to scroll the text
def scroll_text(x):
    global nbr_scroll
    if len(tab_utilisateur) > 0:
        utilisateur_random = randint(0, len(tab_utilisateur) - 1)
        label['text'] = tab_utilisateur[utilisateur_random]
        if x <= nbr_scroll:
            x += 1
            label.after(50, scroll_text, x)
        else:
            tab_utilisateur.pop(utilisateur_random)
    else:
        label['text'] = "Tout le monde est passé!"

# FR: Fonction de démarrage du défilement
# EN: Function to start the scrolling
def start_scroll():
    global nbr_scroll
    nbr_scroll = randint(10, 20)
    scroll_text(0)

# FR: Créer la fenêtre principale
# EN: Create the main window
fenetre = tk.Tk()
fenetre.title("Tirage")
fenetre.geometry("800x400")

# FR: Créer un label
# EN: Create a label
label = tk.Label(fenetre, text="QUI VA GAGNER ?", font=("Helvetica", 25))
label.place(relx=0.5, rely=0.4, anchor="center")

# FR: Créer un bouton pour lancer le défilement
# EN: Create a button to start scrolling
start_button = tk.Button(fenetre, text="C'est parti!", command=start_scroll, font=("Helvetica", 14))
start_button.place(relx=0.5, rely=0.8, anchor="center")

scrolling = False

fenetre.mainloop()
