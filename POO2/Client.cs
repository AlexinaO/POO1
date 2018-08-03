using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Client:Personne
    {
        public string Numero { get; set; }

        public List<ContratLocation>Contrats { get; set; }
    }
}
