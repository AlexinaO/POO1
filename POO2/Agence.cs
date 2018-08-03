using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Agence
    {
        public string Adresse { get; set; }
        public string Ville { get; set; }

        public List<Vehicule> Parc { get; set; }
        public List<Employe> Personnel { get; set; }

    }
}

