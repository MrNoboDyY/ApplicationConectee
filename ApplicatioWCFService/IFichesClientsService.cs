using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;



/// <summary>
/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///  INTERFACE QUI NOUS SERT A CREER LES METHODE / WEBSERVICES avec 
/// </summary>
namespace FichesClientWCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IFichesClientsService
    {

        //WebService permetant de recuperer des fiches clients
        [OperationContract]
        ObservableCollection<FicheClient> GetFiches();
        
        // TODO: ajoutez vos opérations de service ici
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class FicheClient : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        string nom;

        string prenom;

        string sexe;

        int age;


        [DataMember]
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {if(nom != value)
                {
                    nom = value;
                    NotifyPropertyChanged();

                }
            }
        }


        [DataMember]
        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {if(prenom!= value)
                {

                    prenom = value;
                    NotifyPropertyChanged();

                }
                
            }
        }


        [DataMember]
        public string Sexe
        {
            get
            {
                return sexe;
            }

            set
            {if(sexe!= value)
                {
                    sexe = value;
                    NotifyPropertyChanged();
                   
                }
                
            }
        }


        [DataMember]
        public int Age
        {
            get
            {
                return age;
            }

            set
            {if(age!= value)
                {
                    age = value;
                    NotifyPropertyChanged();

                }
            }
        }

          public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }
        

            
       
       }
}
