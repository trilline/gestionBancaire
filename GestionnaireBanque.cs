using System;
using System.Collections.Generic;


public class GestionnaireBanque 
{

  // methode qui permet d'ajouter un utilisateur a une banque 
  public void addUser(Banque banque, Utilisateur user)
  {
    banque.AddUser(user);
  }

  // méthode qui permet d'ajouter une opération bancaire a un utilisateur
  public void AddOpBan(OperationBancaire op, Utilisateur user)
  {
    user.AddOpBancaire(op);
  }

  // méthode qui permet de lister les opérations bancaires par rapport a un utilisateur
  public void listOpBan(OperationBancaire op, Utilisateur user)
  {
    foreach(var operation in user.OpBancaires)
      {
        Console.WriteLine(operation);
      }
  }

  // méthode qui permet de lister les utilisateurs par rapport a une banque. 
  public void listUserBan(Banque banque)
  {
    foreach(var user in banque.ListUser)
      {
        Console.WriteLine(user);
      }
  }
}