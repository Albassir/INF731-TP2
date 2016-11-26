
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
 */
public class ClientIndividuel : Client
{
    private const double TAUX_INTÉRÊT_ANNUEL = 2.25;

    private string nomClient;
    private string prénomClient;

    private string NomClient
    {
    get 
        {
            return nomClient;
        }
    set 
        {
            nomClient = value;
        }
    }

    private string PrénomClient
    {
    get 
        {
            return prénomClient;
        }
    set 
        {
            prénomClient = value;
        }
    }

    public ClientIndividuel (string numéroClient,string nomClient,string prénomClient)
        : base(numéroClient)
    {
        NomClient=nomClient;
        PrénomClient=prénomClient;
    }

   
    public override void AfficherClient ()
    {
        
    }

}