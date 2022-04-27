using System;
using System.Collections.Generic;


public class BanquePhysique : Banque
{ 

  

  public BanquePhysique (string nom, string adresse, List<Utilisateur> users,string typeBanque) : base(nom, adresse, users)
    {

    Console.WriteLine ("Une Banque physique a été crée");
    this.typeBanque ="BanquePhysique";
    }

   public override string ToString() 
 { 
    return $"Banque Physique: {Nom} situé à {Adresse}.";
 
}
}