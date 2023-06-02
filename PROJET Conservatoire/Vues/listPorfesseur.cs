using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PROJET_Conservatoire.Controleurs;
using PROJET_Conservatoire.DAL;
using PROJET_Conservatoire.Models;
using PROJET_Conservatoire.Vues;


namespace PROJET_Conservatoire.Vues
{
    public partial class listPorfesseur : Form
    {
        Mgr manager = new Mgr();
        List<Prof> ListProf = new List<Prof>();

        public listPorfesseur()
        {
            InitializeComponent();

        }

        public void affiche()
        {
            try
            {
                listBox1.DataSource = null;
                listBox1.DataSource = ListProf;
                listBox1.DisplayMember = "Description";

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Supprime
        private void button1_Click(object sender, EventArgs e)
        {
            Prof Pr = (Prof)listBox1.SelectedItem;
            int id = Pr.Id;

            bool etatSupression = manager.supressionProf(id);

            if (etatSupression == true)
            {
                MessageBox.Show("Professeur supprimé");
            }
            else
            {
                MessageBox.Show("Supression impossible car ce professeur à au moins 1 cours attribué !");
            }

            reactualisation();
        }

        

        public void reactualisation()
        {

            ListProf = manager.chargementEmpBD();

            if (ListProf.Count() == 0)
            {

/*                VoirCours.Hide();
*/                button3.Hide();
                  button2.Hide();

            }
            else
            {

/*                VoirCours.Show();
*/                button3.Show();
                  button2.Show();

                affiche();
            }

        }

        private void ListeProf_Load(object sender, EventArgs e)
        {
            ListProf = manager.chargementEmpBD();
            affiche();
        }

        //Ajouter un professeur
        private void button2_Click(object sender, EventArgs e)
        {
            Prof Pr = (Prof)listBox1.SelectedItem;

            gestionProf ajouterUnProf = new gestionProf(Pr); //envoi vers le constructeur
            ajouterUnProf.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prof Pr = (Prof)listBox1.SelectedItem;

            gestionProf modifierUnProf = new gestionProf(Pr); //envoi vers le constructeur surchargé
            modifierUnProf.ShowDialog();
        }
    }
}
