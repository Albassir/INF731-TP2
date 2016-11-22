
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace INF731_TP2
{
    public class ClientIndividuel : Client
    {
        #region // Déclaration des attributs
        public string NomClient { get; private set; }
        public string PrénomClient { get; private set; }
        #endregion


        #region // Déclaration des propriétés
        #endregion


        #region // Déclaration des constructeurs de class

        public ClientIndividuel(string numéroClient, string nom, string prénom)
            : base(numéroClient)
        {
            NomClient = nom;
            PrénomClient = prénom;
        }

        #endregion


        #region // Déclaration des méthodes
      
        /*
        * Méthode: Afficher()
        * Description: Affiche NuméroClient[EOL] Nom, Prénom
        */
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine(NomClient + ", " + PrénomClient);
        }

        #endregion
    }
}