// Entry point name must be "Solution"
using System;

 
    public class CompteChéque : Compte , ICalcul {
    
    private const double FRAIS_PAR_CHÉQUE = 0.50;
    private const double MINIMUM_SOLDE = 1000;
    private const double TAUX_INTÉRÊT_ANNUEL = 0.5; 
    private  double soldePlusBas;
    Private double leTauxInteretAnnuel;

    /* Constructeur parametrique */
        
     Public CompteFlexible (string numéroDeCompte, string numéroClient, string typeDeCompte, string caracteristiqueDeCompte, string              statutCompte, double soldeCompte,double soldPlusBas,double leTauxInteretAnnuel)
    : base (numéroDeCompte,numéroClient,typeDeCompte,caracteristiqueDeCompte,statutCompte,soldeCompte)
    {
         SoldePlusBas = soldPlusBas;
    }
  
           
    public override void Retirer(double montant) 
    {                          
     
      if (solde >= montant)
     {
               solde -= montant;
               Console.Out.WriteLine("Opération bien effectuée");
      }
     else
          Console.Out.WriteLine("Solde insuffisant");
       }
        
        public double Solde                                          
       {
           get { return solde; }                                     //Le solde est en lecture seule
            
           // à revoir 
            {								
                TAUX_INTÉRÊT_ANNUEL = leTauxInteretAnnuel;
            }
	 
           public	void	AjouterInteretsAnnuel()				
            {	double	interets=solde	*	TAUX_INTÉRÊT_ANNUEL;
             solde	+=	interets;
            }
	
 

    }
}
