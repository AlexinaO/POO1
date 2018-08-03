using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Camionette:Vehicule
    {
        public int PoidsMaxEnKilo { get; set; }
        public int PrixJour { get; set; }

        public override double GetPrixJour()
        {
            return PrixJour;
        }
    }
}

