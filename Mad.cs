using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class Mad
    {
        protected double valeur;
        private string type;

        public double Valeur
        {
            get { return valeur; }
        }
        public string Type
        {
            get { return type; }
        }

        public Mad(double Valeur,string Type)
        {
            valeur = Valeur;
            type = Type;
        }


        public string afficher()
        {
            return "La valeur est  " + valeur +"" + Type;
        }

        public static Mad operator +(Mad solde, Mad montant)
        {
            return solde + montant;
        }

        public static Mad operator -(Mad solde, Mad montant)
        {
            return solde - montant;
        }
    }
}






