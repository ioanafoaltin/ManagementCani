using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cana.ViewModels
{
    class AdaugaMagazinViewModel
    {
        public AdaugaMagazinViewModel(MainViewModel mainVM)
        {
            MainViewModel = mainVM;

        }

        private String _nume;
        public string Nume
        {
            get { return _nume; }
            set
            {
                _nume = value;
            }
        }

        public DelegateCommand OkCommand { get; set; }
        public DelegateCommand StergeMagazinComand { get; set; }
        public MainViewModel MainViewModel { get; internal set; }
        public Window Window { get; internal set; }

        public void AdaugaMagazin()
        {
            // incearca sa intelegi cum functioneaza adaugarea, prin schema:
            
            MagazinViewModel magazinNou = new MagazinViewModel();
            magazinNou.MainViewModel = MainViewModel;
            magazinNou.Nume = Nume;

            MainViewModel.Magazine.Add(magazinNou);


            Window.Close();
        }
    }
}
