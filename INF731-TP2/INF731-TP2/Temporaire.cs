//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace INF731_TP2
//{
//    public class Fichiers
//    {
//        class Client
//        {
//            private string[] v;


//            public Client(String src)
//            {
//                this.v = src.Split(';');
//            }
//        }

//        class ClientIndividuel : Client
//        {
//            public String Machin;
//            public String Truc;
//            public String Gugus;

//            public ClientIndividuel(String src)
//            {
//                base(src);

//                this.Machin = base.v[0];
//                this.Truc = base.v[1];
//                this.Gugus = base.v[2];
//            }
//        }

//        static List<ClientIndividuel> Clients(String Chemin)
//        {
//            // Le chemin est un paramètre qui contient les deux informations ci-dessous.
//            //const string CHEMIN_SORTIE = "../../";
//            //const string nomFichier = "listeClients.txt";
//            List<ClientIndividuel> mesClients = new List<ClientIndividuel>();

//            foreach (var Ligne in File.ReadLines(Chemin))
//                mesClients.add(new ClientIndividuel(Ligne));

//            return mesClients;
//        }

//        public class Compte
//        {
//            private Byte Incr = 0;
//            public Object Client;
//            public Object ClientConjoint;
//            public Object Type;
//            public Object Caractéristique;
//            public String Numéro;
//            public String Status;
//            public String Solde;
//        }
//        public class Épargne : Compte { }
//        public class Flexible : Compte { }
//        public class Chèque : Compte { }

//        public class Comptes
//        { public List<Compte> = new List<Compte>(); }

//        public void Charger(String src)
//        {
//            String[] v = src.Split(';');

//            this.v = src.Split(';');
//            this.Client = this.v[0];
//            this.Type = this.v[1];
//            this.Caractéristique = this.v[2];

//            if (this.Caractéristique == "conjoint")
//            {
//                this.Client = this.v[3];
//                this.Incr = 1;
//            }
//        }

//        class CompteChèque : CompteChèque
//        {
//            public ClientIndividuel(String src)
//            {
//                base(src);

//                base.Numéro = base.v[base.Incr + 3];
//                base.Status = base.v[base.Incr + 4];
//                base.Solde = base.v[base.Incr + 5];
//            }
//        }

//        class CompteChèque : CompteFlexible
//        {
//            public String Solde;
//            public String Solde;
//            public String Solde;

//            public ClientIndividuel(String src)
//            {
//                base(src);

//                base.Numéro = base.v[base.Incr + 3];
//                base.Status = base.v[base.Incr + 4];
//                base.Solde = base.v[base.Incr + 5];
//            }
//        }

//        class CompteChèque : CompteÉpargne
//        {
//            public ClientIndividuel(String src)
//            {
//                base(src);

//                base.Numéro = base.v[base.Incr + 3];
//                base.Status = base.v[base.Incr + 4];
//                base.Solde = base.v[base.Incr + 5];
//            }
//        }

//        static List<Compte> Comptes(String Chemin)
//        {
//            Comptes Comptes = new Comptes();

//            foreach (var Ligne in File.ReadLines(Chemin))
//                Comptes.Charger(Ligne);

//            switch (typeDeCompte)
//            {
//                case "Chèque":
//                    Chèque(tableauDesÉléments, i);

//                    numéroCompte = tableauDesÉléments[i + 3];
//                    statutCompte = char.Parse(tableauDesÉléments[i + 4]);
//                    soldeCompte = double.Parse(tableauDesÉléments[i + 5]);
//                    break;
//                case "flexible":
//                    modeFacturation = tableauDesÉléments[i + 3];
//                    numéroCompte = tableauDesÉléments[i + 4];
//                    statutCompte = char.Parse(tableauDesÉléments[i + 5]);
//                    soldeCompte = double.Parse(tableauDesÉléments[i + 6]);
//                    montantMarge = double.Parse(tableauDesÉléments[i + 7]);
//                    soldeMarge = double.Parse(tableauDesÉléments[i + 8]);
//                    break;
//                case "saving":
//                    numéroCompte = tableauDesÉléments[i + 3];
//                    statutCompte = char.Parse(tableauDesÉléments[i + 4]);
//                    soldeCompte = double.Parse(tableauDesÉléments[i + 5]);
//                    break;
//                case default:

//                    // throw new exception
//                    break;
//            }
//        }
//        fichierSource.Close();
//        }
//#endregion
//}
//}