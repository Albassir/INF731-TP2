using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region // Declaration des exceptions
class SoldeMoyenNegatifException : ApplicationException { }
class TypeCompteInvalide : ApplicationException { }
#endregion

/**
 * 
 */
namespace INF731_TP2
{
   public class CompteÉpargne : Compte
   {
      #region // Déclaration des attributs 

      public const double TAUX_INTÉRÊT_ANNUEL = 0.00225;
      private double soldeMoyen;

      #endregion


      #region // Déclaration des propriétés

      public double SoldeMoyen
      {
         get { return soldeMoyen; }

         // Validation du solde moyen au cas ou le solde moyen est inferieur a zero.

         private set
         {
            if (soldeMoyen < 0)
            {
               throw new SoldeMoyenNegatifException();
            }
            else
            {
               soldeMoyen = value;
            }
         }
      }

      #endregion


      #region // Déclaration des constructeurs

      public CompteÉpargne(string[] numéroClient, string typeDeCompte, string caracteristiqueDeCompte, string numéroCompte, char statutCompte, double soldeCompte)
          : base(numéroClient, typeDeCompte, caracteristiqueDeCompte, numéroCompte, statutCompte, soldeCompte)
      {
         if (typeDeCompte != "épargne")
         {
            throw new TypeCompteInvalide();
         }
      }

      #endregion


      #region // Déclaration des Methodes

      // méthode dépot montant
      /**
       * 
       */
      public override bool Déposer(double montant)
      {
         if (EstActif())
         {
            base.SoldeCompte += montant;
            return true;
         }
         else
         {
            return false;
         }

      }


      // Calcul Interets Annuel
      /**
       * 
       */
      public override bool AjouterIntérêt()
      {
         if (EstActif())
         {
            double Intérêts = SoldeMoyen * TAUX_INTÉRÊT_ANNUEL;
            SoldeCompte += Intérêts;
            return true;
         }
         else
         {
            return false;
         }
      }

      /*
      * Méthode: Afficher()
      * @param 
      */
      public override void Afficher()
      {
         base.Afficher();
         Console.WriteLine();
      }

      #endregion
   }
}