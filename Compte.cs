using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banque
{
    public class Compte
    {
        private readonly int numCompte;
        private static int cpt = 0;
        private Client titulaire;
        private Mad solde;
 

        public Client Titulaire
        {
            get { return titulaire; }
        }

        public Mad Solde
        {
            get { return solde; }
        } 

        public Compte(Client Titulaire, Mad Solde)
        {
            Assert.Positive(int numCompte);
            numCompte = ++cpt; 
            titulaire = Titulaire;       
            solde = Solde;
        }

        public void Crediter(Mad montant)
        {
            solde += montant;
        }

        public void Debiter(Mad montant)
        {
            solde -= montant;
        }

        public string afficher()
        {
            string Titulaire = titulaire.Prenom + " " + titulaire.Nom + " " + titulaire.adresse;
            double Solde = solde.Valeur;
            return "Le compte de " +numCompte+ "" +Titulaire + " est de " +Solde ;
        }
    }
}
}

    