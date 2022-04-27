using System;
using System.Collections.Generic;


public class OperationBancaire {
  public string _typeOp;
  public string typeOp{
            get => _typeOp;
            set => _typeOp = value;
  }
  public string _dateOp;
  public string dateOp{
            get => _dateOp;
            set => _dateOp = value;
  }
   

  public OperationBancaire (string typeOp, string dateOp)
  {
    Console.WriteLine("Nouvelle Opération Bancaire de type : "+typeOp);
    this.typeOp = typeOp;
    this.dateOp = dateOp;
  }

//Methode crédité et Débiter dans la classe utilisateur

  //Methode historique
  public void historique(Utilisateur user)
  {
    Console.WriteLine ("--------------Historique-------------");
    for (int i=1; i<= user.OpBancaires.Count; i++)
    {
      foreach(var op in user.OpBancaires)
      {
        Console.WriteLine("operation n°:"+ i);
         Console.Write(op.typeOp) ;
        Console.Write(op.dateOp);
      }
    }
    
  }

  public void ViewAccountInformation(Utilisateur user, Banque banque)
  {
    Console.WriteLine("(--------Information Compte--------");
    Console.WriteLine("Type de Banque:"+ banque.typeBanque);
    Console.WriteLine("Nom de la Banque:"+ banque.Nom);
    Console.WriteLine("Adresse de la Banque:"+ banque.Adresse);
    Console.WriteLine("Nom:"+ user.Nom);
    Console.WriteLine("Nom:"+ user.Prenom);
    Console.WriteLine("Nom:"+ user.Solde);
    Console.WriteLine("(--------Information Compte--------");


  }

  public void displayInfo(Utilisateur user)
  {
    Console.WriteLine($"Info: L'utilisateur {user.Nom}  {user.Prenom} est associé a un compte dont le solde est de :  {user.Solde}");
  }

  public override string ToString() 
     { 
        return $"Un {typeOp} a été réalisé à la date de:{dateOp}";
     }
}

