from random import randint
import tkinter as tk

# FR: ouvre le fichier texte_ascii.txt en lecture
# EN: opens the text_ascii.txt file in read mode
file_user = open("utilisateur.txt", "r", encoding="utf-8")

# FR: lit le fichier et enregistre le texte
# EN: reads the file and saves the text
tab_user = file_user.readlines()
file_user.close()

# FR: Fonction de défilement du texte
# EN: Function to scroll the text
def scroll_text():
    utilisateur_random = randint(0, len(tab_user) - 1)
    label['text'] = tab_user[utilisateur_random]
    if scrolling:
        label.after(50, scroll_text)

# FR: Fonction de démarrage du défilement
# EN: Function to start the scrolling
def start_scroll():
    global scrolling
    scrolling = True
    scroll_text()

# FR: Fonction d'arrêt du défilement
# EN: Function to stop the scrolling
def stop_scroll():
    global scrolling
    scrolling = False

# FR: FR: Créer la fenêtre principale
# EN: EN: Create the main window
fenetre = tk.Tk()
fenetre.title("Tirage")
fenetre.geometry("800x400")


# FR: Créer un label
# EN: Create a label
label = tk.Label(fenetre, text="QUI VA GAGNER ?", font=("Helvetica", 25))
label.place(relx=0.5, rely=0.4, anchor="center")

# FR: Créer un bouton pour lancer le défilement
# EN: Create a button to start scrolling
start_button = tk.Button(fenetre, text="Start Scrolling", command=start_scroll, font=("Helvetica", 14))
start_button.place(relx=0.35, rely=0.8, anchor="center")

# FR: Créer un bouton pour stoper le défilement
# EN: Create a button to stop scrolling
stop_button = tk.Button(fenetre, text="Stop Scrolling", command=stop_scroll, font=("Helvetica", 14))
stop_button.place(relx=0.65, rely=0.8, anchor="center")

scrolling = False

fenetre.mainloop()
