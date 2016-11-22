using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF731_TP2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Génération de la banque avec des comptes et clients
            Banque Tangerine = new Banque("Tangerine");

            string FichierClient = "../../ListeDeClients.txt";
            foreach (Client client in (GestionFichiers.loadClients(FichierClient)))
                Tangerine.AjouterClient(client);
            foreach (Client c in Tangerine.ListeDeClients)
            {
                c.Afficher();
            }


            //string FichierComptes = "../../ListeDeComptes.txt";
            string FichierComptes = "../../fichierTestCompte.txt";
            foreach ( Compte compte in (GestionFichiers.loadComptes(FichierComptes)) )
                Tangerine.AjouterCompte(compte);
            foreach (Compte c in Tangerine.ListeDeComptes)
            {
                c.Afficher();
            }

            //// Test Exception CompteTypeInvalide
            //string[] numeroclient = { "123", "123" };
            //Compte testCompte = new CompteChèque(numeroclient, "something","individuel","123456",'A',300.00);


            // Test des méthodes de class
            // CompteChèque.Retirer()
        }
    }
}
