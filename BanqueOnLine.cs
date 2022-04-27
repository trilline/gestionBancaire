using System;
using System.Collections.Generic;



public class BanqueOnLine : Banque
{


public BanqueOnLine (string nom, string adresse)
:base(nom, adresse)
{
}
  public BanqueOnLine (string nom, string adresse,List<Utilisateur> users, string typeBanque) : base(nom, adresse, users)
    {
    Console.WriteLine ("Une Banque en ligne a été crée");
    this.typeBanque =typeBanque;
    }

  public override string ToString() 
    { 
      return $"Banque en Ligne: {Nom} situé à {Adresse}.";
    } 
}