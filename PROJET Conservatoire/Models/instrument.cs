using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_Conservatoire.Models
{
    public class instrument
    {

        private string libelle;


        public instrument(string unLibelle)
        {

            this.libelle = unLibelle;

        }

        public override string ToString()

        {

            return (this.libelle);
        }



    }
}
