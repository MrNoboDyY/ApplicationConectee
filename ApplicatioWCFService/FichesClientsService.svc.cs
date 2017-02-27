using ApplicatioWCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections.ObjectModel;

namespace FichesClientWCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class FichesClientsService : IFichesClientsService
    {

        //implementation methode "GetFiches() qui renvoie la collection Observable de fiches clients "
        public ObservableCollection<FicheClient> GetFiches()
        {
            ObservableCollection<FicheClient> collec = null;

            //connexion a la base
            using (var entities = new FichesClientsEntities())
            {

                //recuperation de tous mes clients converti en fiche client
                collec = new ObservableCollection<FicheClient>(entities.Clients.Select(client => new FicheClient()
                {

                    //conversion en fiche clients
                    Nom = client.Nom,
                    Prenom = client.Prenom,
                    Age = client.Age.Value,
                    Sexe = client.Sexe
                }
                ));
            }

        return collec;
            /*throw new NotImplementedException();*/
        }
    }

}
