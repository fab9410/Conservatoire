using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PROJET_Conservatoire.Controleurs;

namespace PROJET_Conservatoire.Vues
{
    public partial class ConnexionPage : Form
    {
        Mgr monManager = new Mgr();
        public ConnexionPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
            string pwd = textBox2.Text;

            bool result = monManager.connexionAdmin( mail, pwd );

            Console.WriteLine(result);

            if(result == true)
            {
                listPorfesseur listeProf = new listPorfesseur();
                listeProf.ShowDialog();
            }

        }

    }
}
