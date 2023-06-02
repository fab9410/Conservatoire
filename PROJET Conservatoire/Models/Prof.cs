using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_Conservatoire.Models
{
    public class Prof
    {
        private string instrument;
        private float salaire;
        private string nom;
        private string prenom;
        private int telephone;
        private string mail;
        private string adresse;
        private int id;

        public Prof(int id, string nom, string prenom, int telephone, string mail, string adresse, string instrument, float salaire)
        {
            this.id = id;
            this.instrument = instrument;
            this.salaire = salaire;
            this.nom = nom;
            this.telephone = telephone;
            this.mail = mail;
            this.adresse = adresse;
            this.prenom = prenom;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Telephone { get => telephone; set => telephone = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Instrument { get => instrument; set => instrument = value; }
        public float Salaire { get => salaire; set => salaire = value; }

        public override string ToString() 
        {
            return (this.prenom + " " + this.nom + ". Informations personnelles : " + this.mail + " - " + this.telephone + ". Adresse " + this.adresse + ". Professeur de " + this.instrument + ". Salaire  de " + this.salaire + " €");

        }

    }
}
