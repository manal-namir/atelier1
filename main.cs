using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class main
    {
        static void Main(string[] args)
        {
            Client cl1 = new Client("Manal", "Namir","casa");
            Client cl2 = new Client("Imane", "Namir", "rabat");

            Mad m1 = new Mad(90000,"mad");
            Mad m2 = new Mad(8000,"mad") ;

            Compte c1 = new Compte(cl1, m1);
            Compte c2 = new Compte(cl2,m2);

            Console.WriteLine("titulaire du compte 2 : " + c2.Titulaire.Nom+ c2.Titulaire.Prenom + c2.Titulaire.adresse);
            c2.afficher();
            c1.afficher();
            c2.Debiter(m2);
            c1.Crediter(m1);
        }
    }
}