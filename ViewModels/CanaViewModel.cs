using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cana.ViewModels
{
    class CanaViewModel
    {
        public String Nume { get; set; }
        public int Capacitate { get; set; }
        public DateTime DataFabricatiei { get; set; }
        public bool SpalaInMasina { get; set; }
        public string UtilaPentru { get; set; }

        public MainViewModel MainViewModel { get; set; }

        public DelegateCommand StergeInListaComand { get; set; }

        public CanaViewModel()
        {

            StergeInListaComand = new DelegateCommand(StergeInListaComand_Execute);
            
        }



        private void StergeInListaComand_Execute()
        {
            MainViewModel.Cani.Remove(this);
        }





    }
}
