using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO2;


namespace Exos
{
    class Program
    {
        static void Main(string[] args)
        {
            var agence = new Agence();
            agence.Nom = "Budget";
            agence.Ville = "Paris";

            var client = new Client();
            client.Nom = "ORSONI";
            client.Prenom = "Alexina";
            client.Numero = "00001";

            var categorieCompacte = new CategorieVoiture();
            categorieCompacte.Nom = "Compacte";
            categorieCompacte.PrixJour = 40;

            var categorieFamiliale = new CategorieVoiture();
            categorieFamiliale.Nom = "Familiale";
            categorieFamiliale.PrixJour = 75;

            var voiture1 = new Voiture();
            voiture1.Categorie = categorieCompacte;
            voiture1.Marque = "Citroën";
            voiture1.Modele = "C4 Cactus";

           agence.Parc.Add(voiture1);
            Console.WriteLine($"nombre de voiture: {agence.Parc.Count}");

            var contratLocation = new ContratLocation();
            contratLocation.Client = client;
            contratLocation.DateDebut = DateTime.Today;
            contratLocation.DateFin = DateTime.Today.AddDays(5);
            contratLocation.KilometrageMaximum = 500;
            contratLocation.Vehicule = voiture1;

            Console.WriteLine($"Contrat pour {client.Nom} {client.Prenom}: " + $"{contratLocation.CalculerMontantLocation()} EUR");

            Console.ReadKey();

        }
    }
}
