using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Reflection.Emit;

namespace tirage_interface
{
    public partial class Form1 : Form
    {
        // init
        string[] tab_utilisateur;
        Random aleatoire = new Random();

        public Form1()
        {
            InitializeComponent();

            // FR: lire le fichier et stocker les utilisateurs dans un tableau
            // EN: read the file and store users in an array
            tab_utilisateur = File.ReadAllLines(@".\utilisateur.txt");
        }

        private void btn_tirage_Click(object sender, EventArgs e)
        {
            // FR: Définit un nombre de nom qui va défiler à l'écran
            // EN: Set a number of names to scroll on screen
            int nbrDeDefilement = aleatoire.Next(20, 50);

            // FR: boucle de défilement
            // EN: scroll loop
            for (int i = 1; i <= nbrDeDefilement; i++)
            {
                // FR: génère un nombre aléatoire
                // EN: generates a random number
                int entierRandom = aleatoire.Next(tab_utilisateur.Length);
                label_utilisateur.Text = tab_utilisateur[entierRandom];

                // FR: Centrez le texte verticalement
                // EN: Center text vertically
                label_utilisateur.Left = (this.ClientSize.Width - label_utilisateur.Width) / 2;


                // FR: Rafraîchir l'interface utilisateur
                // EN: Refresh user interface
                Application.DoEvents();

                // FR: attendre 0.1s
                // EN: wait 0.1s
                Thread.Sleep(100);
            }
        }
    }
}