﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cana.ViewModels
{
    class ProducatorViewModel
    {
        public string Nume { get; set; }
        public string TaraDeOrigine { get; set; }
        public string OrasulDeOrigine { get; set; }
        public int NumarDeTelefon { get; set; }

        public MainViewModel MainViewModel { get; set; }
        
        public ProducatorViewModel()
        {

        }
    }
}
