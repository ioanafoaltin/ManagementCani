using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cana.ViewModels
{
    class AdaugaFarfurieViewModel
    {
        public AdaugaFarfurieViewModel(MainViewModel mainVM)
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

        private int _stoc;
        public int Stoc
        {
            get { return _stoc; }
            set
            {
                _stoc = value;
            }
        }

        public DelegateCommand OkCommand { get; set; }
        public DelegateCommand StergeMagazinComand { get; set; }
        public MainViewModel MainViewModel { get; internal set; }
        public Window Window { get; internal set; }

        public void AdaugaFarfurie()
        {
            // incearca sa intelegi cum functioneaza adaugarea, prin schema:

            FarfurieViewModel farfurieNoua = new FarfurieViewModel();
            farfurieNoua.MainViewModel = MainViewModel;
            farfurieNoua.Nume = Nume;
            farfurieNoua.Stoc = Stoc;

            MainViewModel.Farfurii.Add(farfurieNoua);


            Window.Close();
        }
    }
}
