﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class ContratLocation
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int KilometrageMaximum { get; set; }

        public Client Client { get; set; }
        public Vehicule Vehicule { get; set; }

        public double CalculerMontantLocation()
            {
            var nbJours = (DateFin - DateDebut).TotalDays;

            return Vehicule.GetPrixJour() * nbJours;
            }
        
    }
}
