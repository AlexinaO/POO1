using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Agence
    { 
        public Agence()
        {
            Parc = new List<Vehicule>();
            Personnel = new List<Employe>();
        }
        public string Adresse { get; set; }
        public string Nom { get; set; }
        public string Ville { get; set; }

        public List<Vehicule> Parc { get; set; }
        public List<Employe> Personnel { get; set; }

    }
}

