using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO1.POO2;


namespace Exos
{
    class Program
    {
        static void Main(string[] args)
        {
            var agence = new Agence.Agence();
            agence.Nom = "Budget";
            agence.Ville = "Paris";

            var client = new Client();
            client.Nom = "ORSONI";
            client.Prenom = "Alexina";
            client.Numero = "00001";

            var categorieVoiture1 = new CategorieVoiture();
            categorieVoiture1.Nom = "Compacte";
            categorieVoiture1.PrixJour = 40;

            var categorieVoiture2 = new CategorieVoiture();
            categorieFamiliale.Nom = "Familiale";
            categorieFmailiale.PrixJour = 75;

            var voiture1 = new Voiture();
            voiture1.Categorie = categorieCompacte;
            voiture1.Marque = "Citroën";
            voiture1.Modele = "C4 Cactus";

           agence.Parc.Add(voiture1);
            Console.WriteLine($"nombre de voiture: {agence.Parc.Count}");

            var contratLocation = new ContratLocation();
            contratLocation.Client = client;
            contratLocation.Datedebut = DateTime.Today;
            contratLocation.DateFin = DateTime.Today.AddDays(5);
            contratLocation.KilometrageMaximum = 500;
            contratLocation.Vehicule = voiture1;

            Console.WriteLine($"Contrat pour {client.Nom} {client.Prenom}: " + $"{contratLocation.CalculerMontantLocation()} EUR");

            Console.ReadKey();

        }
    }
}
