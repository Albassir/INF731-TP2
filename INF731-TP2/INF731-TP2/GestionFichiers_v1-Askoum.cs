using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace INF731_TP2
{
    static class GestionFichiers
    {
        #region Déclaration des attributs
        const string CHEMIN_SORTIE = "../../";
        #endregion


        #region Déclaration des propriétés
        #endregion

        #region Déclaration des méthodes

        /**
         * 
         */
        static void LireFichierCLient()
        {
            ClientIndividuel monClient;
            const string nomFichier = "listeClients.txt";
            StreamReader fichierSource;
            string ligneLue;
            string[] tableauDesElements;
            char[] tableauDesSeparateurs = new char[] { ';' };

            fichierSource = new StreamReader(CHEMIN_SORTIE + nomFichier);
            while (!fichierSource.EndOfStream)
            {
                ligneLue = fichierSource.ReadLine();
                tableauDesElements = ligneLue.Split(tableauDesSeparateurs);

                string numéroClient = tableauDesElements[0];
                string nomClient = tableauDesElements[1];
                string prénomClient = tableauDesElements[2];
                //   monclient.AfficherClient(new ClientIndividuel(numéroClient, nomClient, prénomClient));
            }
            fichierSource.Close();
        }

        /**
         * 
         */
        static void LireFichierCompte()
        {
            // Compte monCompte = new Compte();

            // Tous les attributs de compte
            string[] numéroClients = new string[2];
            string typeDeCompte;
            string caracteristiqueDeCompte;
            string numéroCompte;
            char statutCompte;
            double soldeCompte;

            // Compte Flexible
            string modeFacturation;
            double montantMarge;
            double soldeMarge;

            // Gestion parsing de fichiers
            const string nomFichier = "listeCompte.txt";
            StreamReader fichierSource;
            string ligneLue;
            string[] tableauDesÉléments;
            char[] tableauDesSéparateurs = new char[] { ';' };


            var Lignes = File.ReadLines(CHEMIN_SORTIE + nomFichier);
            foreach (var Ligne in Lignes)
            {
                tableauDesÉléments = Ligne.Split(';');

                string numéroClient = tableauDesÉléments[0];
                string nomClient = tableauDesÉléments[1];
                string prénomClient = tableauDesÉléments[2];
            }

            fichierSource = new StreamReader(CHEMIN_SORTIE + nomFichier);
            while (!fichierSource.EndOfStream)
            {
                int i = 0;
                ligneLue = fichierSource.ReadLine();
                tableauDesÉléments = ligneLue.Split(tableauDesSéparateurs);

                numéroClients[0] = tableauDesÉléments[i]; i++;
                typeDeCompte = tableauDesÉléments[i]; i++;
                caracteristiqueDeCompte = tableauDesÉléments[i]; i++;

                if (caracteristiqueDeCompte == "conjoint")
                {
                    numéroClients[1] = tableauDesÉléments[i]; i++;
                }

                switch (typeDeCompte)
                {
                    case "Chèque":
                    numéroCompte = tableauDesÉléments[i]; i++;
                    statutCompte = char.Parse(tableauDesÉléments[i]); i++;
                    soldeCompte = double.Parse(tableauDesÉléments[i]); i++;
                    break;
                case "flexible":
                    modeFacturation = tableauDesÉléments[i]; i++;
                    numéroCompte = tableauDesÉléments[i]; i++;
                    statutCompte = char.Parse(tableauDesÉléments[i]); i++;
                    soldeCompte = double.Parse(tableauDesÉléments[i]); i++;
                    montantMarge = double.Parse(tableauDesÉléments[i]); i++;
                    soldeMarge = double.Parse(tableauDesÉléments[i]); i++;
                    break;
                case "saving":
                    numéroCompte = tableauDesÉléments[i]; i++;
                    statutCompte = char.Parse(tableauDesÉléments[i]); i++;
                    soldeCompte = double.Parse(tableauDesÉléments[i]); i++;
                    break;
                //case default:
                //        Console.WriteLine("test");
                //    // throw new exception
                //    break;
                }
            }
            fichierSource.Close();
        }


        /**
         * 
         */
        static void LireFichierTransaction()
        {
            // TODO implement here
        }

        /**
         * 
         */
        static void ÉcrireJournalTransaction()
        {
            // TODO implement here
        }

        /**
         * 
         */
        static void EcrireJournalClient()
        {
            // TODO implement here
        }

        /**
         * 
         */
        static void EcrireJournalCompte()
        {
            // TODO implement here
        }
        #endregion
    }
}