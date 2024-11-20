using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Générateur_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfficherfichier_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            String ligne;
            OFD.Title = "Les fichiers texte."; //titre de la boite de dialogue
            OFD.Filter = "Fichiers texte|*.txt";// Filtre : n'affiche que les fichiers ".txt"

            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    lbxContenuFichier.Items.Clear();  // vider la listbox
                    StreamReader SR = new StreamReader(OFD.OpenFile()); // Ouvrir le flux en lecture
                    while ((ligne = SR.ReadLine()) != null) //lire le fichier ligne par ligne
                    {
                        lbxContenuFichier.Items.Add(ligne); // copier les lignes du fichier dans la listBox
                    }
                    SR.Close(); // fermer le flux
                }
                catch
                {
                    MessageBox.Show("Erreur: Lecture du fichier impossible");
                }
            }

        }
    }
}