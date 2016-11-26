using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public abstract class Client {

    // Déclaration des attributs
    
    private string numéroClient;

    
    // Déclaration des propriétés

    private string NumeroClient
    {
        get 
        {
            return numéroClient;
        }
        set 
        {
            numéroClient=value;
        }
    }

    
    // Déclaration des constructeurs de class

    public Client ( string numéroClient)
    {
        NumeroClient=numéroClient;
        
    }

    
    // Déclaration des méthodes
    
    public abstract void AfficherClient ()

}