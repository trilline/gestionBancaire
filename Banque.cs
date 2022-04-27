using System;
using System.Collections.Generic;

public class Banque {

  private string _Nom;  // the name field
        public string Nom    // the Name property
        {
            get => _Nom;
            set => _Nom = value;
        }
  private string _Adresse; 
  public string Adresse {
            get => _Adresse;
            set => _Adresse = value;
  }

    public string _typeBanque;
  public string typeBanque{
            get => _typeBanque;
            protected set => _typeBanque = value;
  }
    
  private List<Utilisateur> _ListUser;
  public List<Utilisateur> ListUser {
   get => _ListUser; 
  set=>_ListUser = value;  
  }
/*Adder pour la prop listUser*/
    public void AddUser(Utilisateur user)
    {
      _ListUser.Add(user);
    }

  public Banque(string Nom, string Adresse)
    : this(Nom, Adresse,new List<Utilisateur>())
  {
  }

  public Banque(string Nom, string Adresse, List<Utilisateur> Users)
        {
        this.Nom = Nom;
        this.Adresse = Adresse;
        this.ListUser = Users;
        
        }

  public override string ToString() 
    { 
      return $"Banque: {Nom} situé à {Adresse}.";
    }

}