using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Reflection.Emit;
using System.Collections.Generic;

namespace tirage_interface
{
    public partial class Form1 : Form
    {
        // init
        List<string> tab_utilisateur;
        Random aleatoire = new Random();

        public Form1()
        {
            InitializeComponent();

            // FR: lire le fichier et stocker les utilisateurs dans un tableau
            // EN: read the file and store users in an array
            tab_utilisateur = new List<string>(File.ReadAllLines(@".\utilisateur.txt"));
        }

        private void btn_tirage_Click(object sender, EventArgs e)
        {
            if (tab_utilisateur.Count > 0)
            {

                // FR: Définit un nombre de nom qui va défiler à l'écran
                // EN: Set a number of names to scroll on screen
                int nbrDeDefilement = aleatoire.Next(10, 30);
                int entierRandom = 0;

                // FR: boucle de défilement
                // EN: scroll loop
                for (int i = 1; i <= nbrDeDefilement; i++)
                {
                    // FR: génère un nombre aléatoire
                    // EN: generates a random number
                    entierRandom = aleatoire.Next(tab_utilisateur.Count);
                    label_utilisateur.Text = tab_utilisateur[entierRandom];

                    // FR: Centrez le texte verticalement
                    // EN: Center text vertically
                    label_utilisateur.Left = (this.ClientSize.Width - label_utilisateur.Width) / 2;


                    // FR: Rafraîchir l'interface utilisateur
                    // EN: Refresh user interface
                    Application.DoEvents();

                    // FR: attendre 0.1s
                    // EN: wait 0.1s
                    Thread.Sleep(50);
                }

                // FR: retire l'utilisateur de la liste
                // EN: remove user from the list
                tab_utilisateur.RemoveAt(entierRandom);
            }
            else
            {
                label_utilisateur.Text = "Tout le monde est passé!";

                // FR: Centrez le texte verticalement
                // EN: Center text vertically
                label_utilisateur.Left = (this.ClientSize.Width - label_utilisateur.Width) / 2;


                // FR: Rafraîchir l'interface utilisateur
                // EN: Refresh user interface
                Application.DoEvents();
            }
        }
    }
}