using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class Client
    {
        private string nom;
        private string prenom;
        private string Adresse;


        public string Nom
        {
            get { return nom; }
        }

        public string Prenom
        {
            get { return prenom; }
        }

        public string adresse
        {
            get { return Adresse; }
        }
        public Client(string Prenom, string Nom, string adresse)
        {
            nom = Nom;
            prenom = Prenom;
            Adresse = adresse;
        }
        public string afficher()
        {
            return "le client est " + nom + " "  + prenom + " " + Adresse;
        }

        public static implicit operator Client(string v)
        {
            throw new NotImplementedException();
        }
    }
}


