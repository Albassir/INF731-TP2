// Entry point name must be "Solution"
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class CompteFlexible : Compte , ICalcul {
    
    private const double TAUX_INTÉRÊT_ANNUEL = 1.25;
    private const double MARGE_CRÉDIT_MIN = 3000;
    private const double INTÉRÊT_CRÉDIT_ANNUEL = 7.95;
    private const double FRAIS_PIÉCE = 0.60;
    private const double FRAIS_FORFAIT_FIXE = 9;

    /* Attributs */
    public CompteFlexible() {
    }

    /**
     * 
     */
    private double montantMarge;

    /**
     * 
     */
    private double soldeMarge;

    /**
     * 
     */
    private string modeFacturation;

    /**
     * @param montant
    
     */

    public double MontantMarge
    {
        get 
        {
            return montantMarge;
        }

        set
        {
           montantMarge=value;
        }
    }

    public double SoldeMarge
    {
        get 
        {
            return soldeMarge;
        }

        set 
         {
             soldeMarge=value;
         }
    }

    public string ModeFacturation
    {
        get 
        {
            return modeFacturation;
        }

        set 
        {
            modeFacturation=value;
        }
    }
    
    public double SoldePlusBas
    {
        get 
        {
            return soldePlusBas;
        }

        set 
         {
             soldePlusBas=value;
         }
    }

    
    /* Constructeur parametrique */
    
public CompteFlexible (string numéroDeCompte, string numéroClient, string typeDeCompte, string           caracteristiqueDeCompte, string statutCompte, double soldeCompte,double montantMarge,double soldeMarge, string modeFacturation,double soldePlusBas)
    : base (numéroDeCompte,numéroClient,typeDeCompte,caracteristiqueDeCompte,statutCompte,soldeCompte)
    {
        MontantMarge = montantMarge;
        SoldeMarge = soldeMarge;
        ModeFacturation = modeFacturation; 
        SoldePlusBas = soldePlusBas;
    }

      /* Methode Retirer un montant*/
    
    public override void  Retirer(double montant) 
    {
        // TODO implement here

        if (SoldeMarge >= montant)
            {
               SoldeMarge -= montant;
              Console.WriteLine("Opération bien effectuée");
            }
           else
              Console.WriteLine("Solde insuffisant");
    }
 
       /* Methode Deposer un montant*/
    
    public override void Deposer (double montant) 
    {
        // TODO implement here

        if (SoldeMarge >= montant)
            {
               SoldeMarge += montant;
              Console.WriteLine("Opération bien effectuée");
            }
           else
              Console.WriteLine("Solde insuffisant");
    }
    
    
    


}