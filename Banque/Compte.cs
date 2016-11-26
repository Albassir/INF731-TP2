
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public abstract class Compte {

    /**
     * 
     */
    
    // Déclaration des Attributs
    
    private list<Client> ListeDeClient {get;set};
    private string numéroCompte;
    private string caracteristiqueDeCompte;
    private string typeDeCompte;
    private string statutCompte;
    private double solde;
    
    
    // Déclaration des propriétés
    
    public Client this [int indice]
    {
        get 
        {
            return ListeDeClient[indice]
        }
        private set
        {
            ListeDeClient[indice]=value;
        }
    }
   
    public string NumeroDeCompte
     {
         get 
         {
            return numeroDeCompte ;
         }
         private set 
         {
             numeroDeCompte=value;
         }
     }

     public string CaracteristiqueDeCompte
     {
         get 
         {
            return caracteristiqueDeCompte ;
         }
         private set 
         {
             caracteristiqueDeCompte=value;
         }
     }
     public string TypeDeCompte
     {
         get 
         {
            return typeDeCompte ;
         }
         private set 
         {
             typeDeCompte=value;
         }
     }

      public string StatutCompte
     {
         get 
         {
            return statutCompte ;
         }
         private set 
         {
             statutCompte=value;
         }
     }

      public string TypeDeTransaction
     {
         get 
         {
            return typeDeTransaction ;
         }
         private set 
         {
             typeDeTransaction=value;
         }
     }

        public double Solde
     {
         get 
         {
            return solde ;
         }
         private set 
         {
             solde=value;
         }
     }
  
    
    // Déclaration des constructeurs

    /**
     * Constructeur paramétrique
     *
     * @param numéroDeCompte
     * @param ListeDeClient
     * @param typeDeCompte
     * @param caracteristiqueDeCompte
     * @param statutCompte
     * @param soldeCompte
     */
    public Compte(list<Client> ListeDeClient, string numéroClient, string typeDeCompte,                         string caracteristiqueDeCompte, string statutCompte, double soldeCompte)
    {
      NuméroDeCompte = numéroDeCompte;
      NuméroClient = numéroClient;
      TypeDeCompte = typeDeCompte;
      CaracteristiqueDeCompte = caracteristiqueDeCompte;
      StatutCompte = statutCompte;
      SoldeCompte = soldeCompte;
    }


    // Déclaration des méthodes
    
    /**
     * 
     */
    public void RendreActif() {
        // TODO implement here
    }

    /**
     * 
     */
    public void RendreInactif() {
        // TODO implement here
    }

    /**
     * 
     */
    public void AfficherSolde() 
    {
     // compte.get(solde)
    }

    /**
     * @return
     */
    public static bool EstActif() {
        // TODO implement here
        return False;
    }

    /**
     * @param montant
     */
    public abstract void Déposer(double montant)
     {
       solde=+montant;
    }

    /**
     * Déplacer dans une interface vu que le compte épargne ne permet pas de faire de retrait
     * @param montant
     */
    public abstract void Retirer(double montant)
     {
       if (solde>=montant)
       {
           solde=-montant;
           
       }
        
    }

    /**
     * 
     */
    public void AjouterIntérêt() {
        // TODO implement here
    }

    /**
     * 
     */
 
    public void AjouterClient( Client valeur) 
    {
       Liste.Add(valeur);
    }

    /**
     * 
     */
    public void RetirerClient() {
        // TODO implement here
    }

}