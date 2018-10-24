using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cana.ViewModels
{
    class FarfurieViewModel
    {
        public string Nume { get; set; }
        public int Stoc { get; set; }

        public MainViewModel MainViewModel { get; set; }

        public FarfurieViewModel()
        {

        }
    }
}
