using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cana.ViewModels
{
    class AdaugaProducatorViewModel
    {

        public AdaugaProducatorViewModel(MainViewModel mainVM)
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

        public string _taraDeOrigine;
        public string TaraDeOrigine
        {
            get { return _taraDeOrigine;}
            set { _taraDeOrigine = value; }
        }

        public string _orasulDeOrigine;
        public string OrasulDeOrigine
        {
            get { return _orasulDeOrigine; }
            set { _orasulDeOrigine = value; }
        }

        public int _numarDeTelefon;
        public int NumarDeTelefon
        {
            get { return _numarDeTelefon; }
            set { _numarDeTelefon = value; }
        }

        public DelegateCommand OkCommand { get; set; }
        public DelegateCommand StergeProducatorComand { get; set; }
        public MainViewModel MainViewModel { get; internal set; }
        public Window Window { get; internal set; }

        public void AdaugaProducator()
        {
            // incearca sa intelegi cum functioneaza adaugarea, prin schema:
            ProducatorViewModel producatorNou = new ProducatorViewModel();
            producatorNou.MainViewModel = MainViewModel;
            producatorNou.Nume = Nume;
            producatorNou.OrasulDeOrigine = OrasulDeOrigine;
            producatorNou.TaraDeOrigine = TaraDeOrigine;
            producatorNou.NumarDeTelefon = NumarDeTelefon;

            MainViewModel.Producatori.Add(producatorNou);

            Window.Close();
        }

    }
}
