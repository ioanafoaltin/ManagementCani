using Cana.Views;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cana.ViewModels
{
    class MainViewModel
    {
        //proprietati de adaugat cana noua, sters cana selectata si prop tine minte toate canile

        public DelegateCommand AdaugaCanaComand { get; private set; }
        public ObservableCollection<CanaViewModel> Cani { get; set; }
        //o proprietate, ca sa semnalizam ce e selectat
        public CanaViewModel SelectedItem { get; set; }
        public DelegateCommand DeleteCanaComand { get; set; }
        public DelegateCommand ClearComand { get; set; }
        public DelegateCommand DubleazaCanileCuAComand { get; set; }
        public DelegateCommand StergeCanileCuEComand { get; set; }
        public DelegateCommand CanaCuMereComand { get; set; }
        public DelegateCommand DacaListaEMaiMareComand { get; set; }
        public DelegateCommand StergeCanileCuAsiIComand { get; set; }
        public DelegateCommand MaiMultDeCinciComand { get; set; }
        public DelegateCommand StergeCaniAriComand { get; set; }
        public DelegateCommand CaniCuIComand { get; set; }
        public DelegateCommand MaiMultDeCinciCaractereComand { get; set; }
        public DelegateCommand CelMaiLungNumeComand { get; set; }
        public DelegateCommand NumarDeCaniCuIComand { get; set; }
        public DelegateCommand CapacitateSpalatVinComand { get; set; }
        public DelegateCommand CeaMaiRecentaCanaDeCeaiIComand { get; set; }
        public DelegateCommand CanileIaurtComand { get; set; }


        public MainViewModel()
        {
            AdaugaCanaComand = new DelegateCommand(AdaugaCanaComand_Execute);
            Cani = new ObservableCollection<CanaViewModel>();
            DeleteCanaComand = new DelegateCommand(DeleteCanaComand_Execute);
            ClearComand = new DelegateCommand(ClearComand_Execute);
            DubleazaCanileCuAComand = new DelegateCommand(DubleazaCanileCuA_Execute);
            StergeCanileCuEComand = new DelegateCommand(StergeCanileCuEComand_Execute);
            CanaCuMereComand = new DelegateCommand(CanaCuMereComand_Execute);
            DacaListaEMaiMareComand = new DelegateCommand(DacaListaEMaiMareComand_Execute);
            StergeCanileCuAsiIComand = new DelegateCommand(StergeCanileCuAsiIComand_Execute);
            MaiMultDeCinciComand = new DelegateCommand(MaiMultDeCinciComand_Execute);
            StergeCaniAriComand = new DelegateCommand(StergeCaniAriComand_Execute);
            CaniCuIComand = new DelegateCommand(CaniCuIComand_Execute);
            MaiMultDeCinciCaractereComand = new DelegateCommand(MaiMultDeCinciCaractereComand_Execute);
            CelMaiLungNumeComand = new DelegateCommand(CelMaiLungNumeComand_Execute);
            NumarDeCaniCuIComand = new DelegateCommand(NumarDeCaniCuIComand_Exectute);
            CapacitateSpalatVinComand = new DelegateCommand(CapacitateSpalatVinComand_Execute);
            CeaMaiRecentaCanaDeCeaiIComand = new DelegateCommand(CeaMaiRecentaCanaDeCeaiIComand_Execute);
            CanileIaurtComand = new DelegateCommand(CanileIaurtComand_Execute);
        }


        private void AdaugaCanaComand_Execute()
        {
            //se construieste view modelul asta
            AdaugaCanaViewModel adaugaCanaViewModel = new AdaugaCanaViewModel();
            //avem nevoie de asta ca sa avem acces la proprietatile din MainViewModel(in special cani)
            adaugaCanaViewModel.MainViewModel = this;
            //x=adaugaCanaViewModel
            
            //am legat proprietatea okComand de metoda AdaugaCana
            adaugaCanaViewModel.OkCommand = new DelegateCommand(adaugaCanaViewModel.AdaugaCana);

            Window fereastraNoua = new Window();
            fereastraNoua.Title = "Adauga o cana";
            fereastraNoua.MinWidth = 50;
            fereastraNoua.MinHeight = 50;
            fereastraNoua.Width = 500;
            fereastraNoua.Height = 500;
            fereastraNoua.Content = new AdaugaCanaView();
            fereastraNoua.DataContext = adaugaCanaViewModel;

            adaugaCanaViewModel.Window = fereastraNoua;

            fereastraNoua.ShowDialog();
        }

        private void DeleteCanaComand_Execute()
        {
            if (Cani.Count != 0)
            {
                Cani.Remove(SelectedItem);
            }
        }

        private void ClearComand_Execute()
        {
            Cani.Clear();
        }



        private void DubleazaCanileCuA_Execute()
        {
            foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.Nume.Contains("a"))
                {
                    CanaViewModel Dublura = new CanaViewModel();
                    Dublura.Nume = cana.Nume;
                    Cani.Add(Dublura);
                }
            }
        }

        private void StergeCanileCuEComand_Execute()
        {
            foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.Nume.Contains("e"))
                {
                    Cani.Remove(cana);
                }
            }
        }

        private void CanaCuMereComand_Execute()
        {
            foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.Nume.ToLower().Equals("pere"))
                {
                    CanaViewModel CuMere = new CanaViewModel();
                    CuMere.Nume = "mere";
                    Cani.Add(CuMere);
                }
            }
        }

        private void DacaListaEMaiMareComand_Execute()
        {
            if (Cani.Count > 6)
            {
                Cani.Remove(Cani[0]);
                Cani.Remove(Cani[0]);
                Cani.Remove(Cani[0]);

            }
        }

        //1. sa se stearga toate canile care contin litera a si i

        private void StergeCanileCuAsiIComand_Execute()
        {
            foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.Nume.Contains("a") && cana.Nume.Contains("i"))
                {
                    Cani.Remove(cana);
                }
            }
        }

        //2. daca sunt mai mult de 5 cani, sa adauge o cana in plus cu numele 5 cani

        private void MaiMultDeCinciComand_Execute()
        {
            if (Cani.Count > 6)
            {
                CanaViewModel CinciCani = new CanaViewModel();
                CinciCani.Nume = "5 cani";
                Cani.Add(CinciCani);
            }
        }

        //4. sa se stearga toate canile care contin textul "ari"

        private void StergeCaniAriComand_Execute()
        {
            foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.Nume.Contains("ari"))
                {
                    Cani.Remove(cana);
                }
            }
        }

        //6. sa se afiseze mesaj daca cana selectata contine litera i

        private void CaniCuIComand_Execute()
        {
            foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.Nume.Contains("i") && cana.Equals(SelectedItem))
                {
                    MessageBox.Show("Cana selectata contine litera I");
                }
            }

        }


        //7. afiseaza daca cana selectata are mai mult de 5 caractere

        private void MaiMultDeCinciCaractereComand_Execute()
        {
            foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.Equals(SelectedItem) && (cana.Nume.Length > 6))
                {
                    MessageBox.Show("Cana selectata contine mai mult de 5 caractere");
                }
            }
        }

        //5. sa se afiseze cu mesaj cana cu cel mai lung nume (MessageBox.Show())


        private void CelMaiLungNumeComand_Execute()
        {
            int max = 0;
            string numeleCelMaiLung = "";


            foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.Nume.Length > max)
                {
                    max = cana.Nume.Length;
                    numeleCelMaiLung = cana.Nume;
                }
            }
            MessageBox.Show("Cana " + numeleCelMaiLung + " are cel mai lung nume");
        }

        //3. buton care da mesaj "exista x numar de cani care contin litera i"

        private void NumarDeCaniCuIComand_Exectute()
        {
            int numarCaniCuI = 0;

            foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.Nume.Contains("i"))
                {
                    numarCaniCuI = numarCaniCuI + 1;
                }
            }
            MessageBox.Show("Exista " + numarCaniCuI + " cani cu i");

        }

        private void CapacitateSpalatVinComand_Execute()
        {
            int max = 0;
            string canaCautata = "";

            foreach (CanaViewModel cana in Cani.ToList())
            {
                if ((cana.Capacitate > max) && (cana.SpalaInMasina = true) && (cana.UtilaPentru.Contains("Vin")))
                {

                    max = cana.Capacitate;
                    canaCautata = cana.Nume;
                }
            }

            MessageBox.Show("Cana cu capacitatea cea mai mare care poate fi spalata la masina de tip vin fiert este " + canaCautata);
        }

        private void CeaMaiRecentaCanaDeCeaiIComand_Execute()
        {
            DateTime celMaiRecent = new DateTime(0001, 01, 01, 0, 0, 0);
            string afisam = "";

            foreach (CanaViewModel cana in Cani.ToList())
            {
                int rezultat = DateTime.Compare(celMaiRecent, cana.DataFabricatiei);
                if (rezultat < 0 && (cana.UtilaPentru.Contains("Ceai")))
                {
                    celMaiRecent = cana.DataFabricatiei;
                    afisam = cana.Nume;
                }
            }
            MessageBox.Show("Cea mai recenta cana de ceai este: " + afisam);
        }

        private void CanileIaurtComand_Execute()
        {
            string canileIaurt = "";
            string afisam = "";

            foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.UtilaPentru.Contains("Iaurt"))
                {
                    canileIaurt = cana.Nume;
                }

                afisam = afisam + canileIaurt + ", ";
            }

            if (afisam.EndsWith(", "))
            {
                afisam = afisam.Substring(0, afisam.Length - 2);
            }

            MessageBox.Show("Canile iaurt sunt: " + afisam);
        }


        







        // tema:
        // DA 1. sa se adauge la cana caracteristica tip, de ales intre cafea, ceai, vin fiert, lapte, cacao, iaurt (combobox)
        // DA 2. sa se adauge o prop numita data fabricarii (date time picker, tip de date date time)
        // DA 3. se poate spala in masina de spalat vase? (adevarat sau fals)
        // DA 4. buton - sa afiseze cana cu capacitatea cea mai mare care poate fi spalata la masina, de tip vin fiert
        // DA 5. buton - sa se afiseze cana de tip ceai cu data fabricarii cea mai recenta
        // DA 6. buton - sa se afiseze numele tuturor canilor de tip iaurt
        // DA 7. in lista de cani - buton de stergere
        // 8. identificat constructorii si vazut cand se apeleaza, schema proprie cu toata structura aplicatiei
        // 9. tab producator - plus, minus, adaugat (forma de) producator va contine numele firmei, tzara si orasul de origine, telefon 

    }
}
