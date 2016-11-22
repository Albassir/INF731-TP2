using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace INF731_TP2
{
    public abstract class Client
    {

        #region // Déclaration des attributs
        public string NuméroClient { get; private set; }
        #endregion


        #region // Déclaration des propriétés
        #endregion


        #region // Déclaration des constructeurs de class

        public Client(string numéroClient)
        {
            NuméroClient = numéroClient;
        }

        #endregion


        #region // Déclaration des méthodes

        /*
        * Méthode: Afficher()
        * Description: Affiche NuméroClient[EOL]
        */
        public virtual void Afficher()
        {
            Console.Write(ToString());
        }

        public override string ToString()
        {            
            return NuméroClient + " - ";
        }
        #endregion
    }
}