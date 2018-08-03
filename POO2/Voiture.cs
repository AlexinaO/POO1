using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Voiture : Vehicule
    {
        public int NbPortes { get; set; } = 5; //on  met le valeur 5 dans NbPortes

        public CategorieVoiture Categorie { get; set; }
    }
}
