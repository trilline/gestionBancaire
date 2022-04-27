using System;
using System.Collections.Generic;

public class Utilisateur
{
  private string _Nom;  
  public string Nom {
    get => _Nom;
    set => _Nom = value;
    
  }
  private string _Prenom;
  public string Prenom{
   get => _Prenom;
    set => _Prenom = value;
    }
  
  private int _Solde;
  public int Solde{
    get => _Solde;
    set => _Solde = value;
  }
  private List<OperationBancaire> _OpBancaires;
  public List<OperationBancaire> OpBancaires
   {
     get => _OpBancaires; 
     set=>_OpBancaires = value;  
    
    }
/*Adder pour la prop opBancaire*/
    public void AddOpBancaire(OperationBancaire op)
    {
        _OpBancaires.Add(op);
    }

    public Utilisateur(string Nom, string Prenom, int Solde)
    : this(Nom, Prenom,Solde,new List<OperationBancaire>())
  {
  }
  
  public Utilisateur(){}
  public Utilisateur(string nom,string prenom,int solde,List<OperationBancaire> Ope)
  {
  this.Nom = nom;
  this.Prenom = prenom;
  this.Solde = solde;
  this.OpBancaires = Ope;
  }

    public override string ToString() 
     { 
        return $"Utilisateur: {Nom} {Prenom} a un solde de {Solde}";
     }

  // Méthode pour créditer le solde d'un utilisateur
  public void Crediter(int Montant, Utilisateur? user)
  {
    if ( user == null)
      {
        this.Solde += Montant;
        Console.WriteLine("le compte de " + this.Nom + "vient d'être créditer d'un montant de " + Montant + " euros");
        Console.WriteLine("le nouveau solde est de : " + this.Solde);
      }
      else if (user != null && user.Solde - Montant >= 0)
      {
        this.Solde += Montant;
        user.Solde -= Montant;
    
        Console.WriteLine("le compte de " + this.Nom + "vient d'être créditer d'un montant de " + Montant + " euros");
        Console.WriteLine("compte debiteur: "+ user.Nom);
        Console.WriteLine("le nouveau solde de"+ this.Nom+ "est de" + this.Solde);
        Console.WriteLine("le nouveau solde de" + user.Nom + "est de" + user.Solde);
  
      }

  }
  // Méthode débiter pour débiter les solde du compte

  public bool Debiter(int Montant, Utilisateur? user)
  {
    if (user == null)
    {
      this.Solde -= Montant;
      Console.WriteLine("le compte de " + this.Nom + "vient d'être débiter d'un montant de " + Montant + " euros");
      Console.WriteLine("le nouveau solde est de : " + this.Solde);
        return true;
    }
    else if (user != null && this.Solde - Montant >= 0)
    {
        this.Solde -= Montant;
        user.Solde += Montant;
        Console.WriteLine("le compte de " + this.Nom + "vient d'être débiter d'un montant de " + Montant + " euros");
        Console.WriteLine("compte créditeur: " + user.Nom);
        Console.WriteLine("le nouveau solde de" + this.Nom + "est de" + this.Solde);
        Console.WriteLine("le nouveau solde de" + user.Nom + "est de" + user.Solde);
        return true;
    }
    else
    {
        Console.WriteLine("Echec d'opération!!! Le user" + this.Nom + " est imposible a debiter car le solde est insuffisant");
      return false;
    }
  }

}