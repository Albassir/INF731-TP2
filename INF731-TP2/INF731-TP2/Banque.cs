
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace INF731_TP2
{
    public class Banque
    {
        #region // Déclaration des attributs

        private string nomBanque;
        public List<Client> ListeDeClients { get; set; } // Propriété automatique
        public List<Compte> ListeDeComptes { get; set; } // Propriété automatique

        #endregion


        #region // Déclaration des propriétés

        public string NomBanque
        {
            get { return nomBanque; }
            private set { nomBanque = value; }
        }

        #endregion


        #region // Déclaration des constructeurs de class

        public Banque(string nomBanque)
        {
            NomBanque = nomBanque;
            ListeDeClients = new List<Client>();
            ListeDeComptes = new List<Compte>();
        }

        #endregion


        #region // Déclaration des méthodes

        /**
         * 
         */
        public void AjouterClient(Client client)
        {
            ListeDeClients.Add(client);
        }

        public void AjouterCompte(Compte compte)
        {
            ListeDeComptes.Add(compte);
        }

        /**
         * 
         */
        public void FermerCompte()
        {
            // TODO implement here
        }

        /**
         * 
         */
        // Retourner un client en fonction de son numéro de client
        public Client TrouverClient(string numéroClient)
        {
            return ListeDeClients.Find(client => client.NuméroClient == numéroClient);

        }

        /**
         * 
         */
        // Retourner la liste des comptes pour un client
        public List<Compte> TrouverLesComptes(Client clientreçus)
        {
            return ListeDeComptes.FindAll(compte => compte.NuméroClients[0] == clientreçus.NuméroClient || compte.NuméroClients[1] == clientreçus.NuméroClient).ToList();
        }

        /**
         * 
         */
        // Retourner la liste des comptes pour un client à partir de son numéro
        public List<Compte> TrouverLesComptes(string numéroClient)
        {
            return ListeDeComptes.FindAll(compte => compte.NuméroClients[0] == numéroClient || compte.NuméroClients[1] == numéroClient).ToList(); // Naviguer la liste de client?
        }

        #endregion
    }
}