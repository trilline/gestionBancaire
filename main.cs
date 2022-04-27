using System;
using System.Collections.Generic;

public delegate void DeleguateManager(List<Utilisateur> user, GestionnaireBanque gestionnaire, List<OperationBancaire> Operations);
class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Gestion Bancaire ");

    //Creation des listes d'utilisateur pour chaque Banque
    List<Utilisateur> postalUsers= new List<Utilisateur>();
    List<Utilisateur> boursoramaUsers= new List<Utilisateur>();

    //Initialisation d'une banque Physique
    Banque LaPoste = new BanquePhysique("La banque Postale", "9 Rue du colonel Pierre Avia 75015  Paris",postalUsers,"Banque Physique");
        //Initialisation d'une banque En ligne
    Banque Boursorama = new BanqueOnLine("Boursorama", "44 RUE TRAVERSIERE 92100 BOULOGNE BILLANCOURT",boursoramaUsers ,"Banque en ligne");
    
    //Test new constructeur
    Banque OrangeBanque = new BanqueOnLine("orangeBanque","12 rue des problèmes");

    //Initialisation d'un gestionnaire Bancaire
    GestionnaireBanque gestionnaire = new GestionnaireBanque();

    //Initialisation de la liste des operation bancaires
    List<OperationBancaire> Ope = new List<OperationBancaire>();
   
   
    
//Creation des utilisateurs associés à chaque banque
    CreateAndAddUserToABanque(LaPoste, postalUsers);
   // CreateAndAddUserToABanque(Boursorama, boursoramaUsers);
   // CreateAndAddUserToABanque(OrangeBanque, postalUsers);

    //listing des utilisateur de chaque banque
    gestionnaire.listUserBan(LaPoste);
   // gestionnaire.listUserBan(Boursorama);
    //gestionnaire.listUserBan(OrangeBanque);

    //create delegate instances
    DeleguateManager delma = new DeleguateManager(Manager);
    delma(postalUsers,gestionnaire, Ope);
    delma(boursoramaUsers,gestionnaire, Ope);
    
    
  } 

  // methode de creation des usere et d'affectation au banque
    static void CreateAndAddUserToABanque(Banque banque, List<Utilisateur> users)
    {
      for(int i =1 ; i<=2 ; i++)
      {
        Console.WriteLine("Saisis Utilisateur n°: "+i);
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("Saisissez un nom :");
        string nom = Console.ReadLine();
        Console.WriteLine("Saisissez un prenom :");
        string prenom = Console.ReadLine();
        Console.WriteLine("Saisissez un solde :");
        int solde = int.Parse(Console.ReadLine());

        Utilisateur user = new Utilisateur();
        user.Nom = nom;
        user.Prenom = prenom;
        user.Solde = solde;
        
        users.Add(user);
      // banque.users.Add(user);
        //banque.setUser(user);
        banque.AddUser(user);
      }
      
    }

  //Methoe pour declencher 03 opérations pour chaque user
  public static void Manager(List<Utilisateur> users, GestionnaireBanque gestionnaire, List<OperationBancaire> Ope )
  {
    foreach (var user in users)
    {
            Console.WriteLine("-----------------------------------------------------");

      //Crédit puis consulter le solde
      OperationBancaire Credit =  new  OperationBancaire("Crédit", DateTime.Now.ToString());
      Console.WriteLine(user);
      Console.WriteLine("Entrer le montant de créditation :");
      int mtnCredit = int.Parse(Console.ReadLine());
      user.Crediter(mtnCredit, null);
      Ope.Add(Credit);

      //Débitpuis consulter le solde
       OperationBancaire Debit =  new  OperationBancaire("Debit", DateTime.Now.ToString());
      Console.WriteLine(user);
      Console.WriteLine("Entrer le montant du débit :");
      int mtnDebit = int.Parse(Console.ReadLine());
      user.Debiter(mtnDebit, null);
      Ope.Add(Debit);
      
    }

    // affichage des in
   
  }
  
}
