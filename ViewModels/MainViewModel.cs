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
        public DelegateCommand AdaugaProducatorComand { get; private set; }
        public DelegateCommand AdaugaMagazinComand { get; set; }
        public DelegateCommand AdaugaFarfurieComand { get; set; }

        public ObservableCollection<CanaViewModel> Cani { get; set; }
        public ObservableCollection<ProducatorViewModel> Producatori { get; set; }
        public ObservableCollection<MagazinViewModel> Magazine { get; set; }
        public ObservableCollection<FarfurieViewModel> Farfurii { get; set; }


        //o proprietate, ca sa semnalizam ce e selectat
        public CanaViewModel SelectedItem { get; set; }
        public ProducatorViewModel SelectedProducator { get; set; }
        public MagazinViewModel SelectedMagazin { get; set; }
        public FarfurieViewModel SelectedFarfurie { get; set; }

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
        public DelegateCommand CanaCeaMaiLungaCuI { get; set; }
        public DelegateCommand CelMaiLungNumeDeFarfurieComand { get; set; }
        public DelegateCommand MaiMultDe50FarfuriiComand { get; set; }
        public DelegateCommand CelMaiLungNumeDeFarfurieCuHComand { get; set; }
        public DelegateCommand CeaMaiLungaFarfurieGriComand { get; set; }
        public DelegateCommand DMicGri100Comand { get; set; }

        //butoane pentrul tabul de producator

        public DelegateCommand StergeProducatorComand { get; set; }
        public DelegateCommand NumeNumarRoComand { get; set; }

        //butoane pentru tabul magazin

        public DelegateCommand StergeMagazinComand { get; set; }

        //butoane pentru farfurie

        public DelegateCommand StergeFarfurieComand { get; set; }
        public DelegateCommand DiametruMareStoc100Comand { get; set; }

        public MainViewModel()
        {

            AdaugaCanaComand = new DelegateCommand(AdaugaCanaComand_Execute);
            AdaugaProducatorComand = new DelegateCommand(AdaugaProducatorComand_Execute);
            AdaugaMagazinComand = new DelegateCommand(AdaugaMagazinComand_Execute);
            AdaugaFarfurieComand = new DelegateCommand(AdaugaFarfurieComand_Execute);

            Cani = new ObservableCollection<CanaViewModel>();
            Producatori = new ObservableCollection<ProducatorViewModel>();
            Magazine = new ObservableCollection<MagazinViewModel>();
            Farfurii = new ObservableCollection<FarfurieViewModel>();

            // comenzi pentru cani
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
            CanaCeaMaiLungaCuI = new DelegateCommand(CanaCeaMaiLungaCuI_Execute);

            //pentru producatori
            StergeProducatorComand = new DelegateCommand(StergeProducatorComand_Execute);
            NumeNumarRoComand = new DelegateCommand(NumeNumarRoComand_Execute);

            //pentru magazine
            StergeMagazinComand = new DelegateCommand(StergeMagazinComand_Execute);

            //pentru farfurii
            StergeFarfurieComand = new DelegateCommand(StergeFarfurieComand_Execute);
            CelMaiLungNumeDeFarfurieComand = new DelegateCommand(CelMaiLungNumeDeFarfurieComand_Execute);
            MaiMultDe50FarfuriiComand = new DelegateCommand(MaiMultDe50FarfuriiComand_Execute);
            CelMaiLungNumeDeFarfurieCuHComand = new DelegateCommand(CelMaiLungNumeDeFarfurieCuHComand_Execute);
            CeaMaiLungaFarfurieGriComand = new DelegateCommand(CeaMaiLungaFarfurieGriComand_Execute);
            DiametruMareStoc100Comand = new DelegateCommand(DiametruMareStoc100Comand_Execute);
            DMicGri100Comand = new DelegateCommand(DMicGri100Comand_Execute);

        }


        private void AdaugaCanaComand_Execute()
        {
            /* int x;
             x = 0;

             Int32 z;

             z = new Int32();*/

            //se construieste view modelul asta
            AdaugaCanaViewModel adaugaCanaViewModel = new AdaugaCanaViewModel(this);
            AdaugaCanaViewModel x = adaugaCanaViewModel;

            //avem nevoie de asta ca sa avem acces la proprietatile din MainViewModel(in special cani)
            //adaugaCanaViewModel.MainViewModel = this;
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

        // ...Comand_Execute() pentru cani

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



        /*private void DubleazaCanileCuA_Execute()
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
        }*/

        private void DubleazaCanileCuA_Execute()
        {

            //var caniCuA = from Cana in Cani where Cana.Nume.Contains("a") select Cana;
            var caniCuA = Cani.Where(c => c.Nume.Contains("a"));

            foreach (var cana in caniCuA.ToList())
            {
                CanaViewModel Dublura = new CanaViewModel();
                Dublura.Nume = cana.Nume;
                Cani.Add(Dublura);
            }


        }

        /* private void StergeCanileCuEComand_Execute()
             {
                 foreach (CanaViewModel cana in Cani.ToList())
                 {
                     {
                         Cani.Remove(cana);
                     }
                 }
             }*/

        private void StergeCanileCuEComand_Execute()
        {
            var caniCuE = Cani.Where(k => k.Nume.Contains("e"));
            foreach (var cana in caniCuE.ToList())
            {
                {
                    Cani.Remove(cana);
                }
            }
        }

        private void CanaCuMereComand_Execute()
        {
            var canaCuMere = Cani.Where(k => k.Nume.Equals("pere"));
            foreach (var cana in canaCuMere.ToList())
            {
                CanaViewModel CuMere = new CanaViewModel();
                CuMere.Nume = "mere";
                Cani.Add(CuMere);
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

        /* private void StergeCanileCuAsiIComand_Execute()
         {
             foreach (CanaViewModel cana in Cani.ToList())
             {
                 if (cana.Nume.Contains("a") && cana.Nume.Contains("i"))
                 {
                     Cani.Remove(cana);
                 }
             }
         }*/

        private void StergeCanileCuAsiIComand_Execute()
        {
            var stergeCanileCuAsiI = Cani.Where(k => k.Nume.Contains("a") && k.Nume.Contains("i"));
            foreach (CanaViewModel cana in Cani.ToList())
            {
                Cani.Remove(cana);
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

        /*private void StergeCaniAriComand_Execute()
        {
            foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.Nume.Contains("ari"))
                {
                    Cani.Remove(cana);
                }
            }
        }*/

        private void StergeCaniAriComand_Execute()
        {
            var caniCuAri = Cani.Where(k => k.Nume.Contains("ari"));
            foreach (var cana in caniCuAri.ToList())
            {
                Cani.Remove(cana);
            }
        }

        //6. sa se afiseze mesaj daca cana selectata contine litera i

        /* private void CaniCuIComand_Execute()
         {
             foreach (CanaViewModel cana in Cani.ToList())
             {
                 if (cana.Nume.Contains("i") && cana.Equals(SelectedItem))
                 {
                     MessageBox.Show("Cana selectata contine litera I");
                 }
             }
         }*/

        private void CaniCuIComand_Execute()
        {
            var caniCuI = Cani.Where(k => k.Nume.Contains("i"));
            MessageBox.Show("Cana selectata contine litera I");
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


        /* private void CelMaiLungNumeComand_Execute()
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
         }*/

        private void CelMaiLungNumeComand_Execute()
        {
            var celMaiLungNume = Cani.OrderByDescending(k => k.Nume.Length).FirstOrDefault().Nume;
            MessageBox.Show("Cana " + celMaiLungNume + " are cel mai lung nume.");
        }

        //3. buton care da mesaj "exista x numar de cani care contin litera i"

        private void NumarDeCaniCuIComand_Exectute()
        {
            int numarCaniCuI = Cani.Count(k => k.Nume.Contains("i"));
            /*foreach (CanaViewModel cana in Cani.ToList())
            {
                if (cana.Nume.Contains("i"))
                {
                    numarCaniCuI = numarCaniCuI + 1;
                }
            }*/
            MessageBox.Show("Exista " + numarCaniCuI + " cani cu i.");

        }

        /*  private void CapacitateSpalatVinComand_Execute()
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
          }*/

        private void CapacitateSpalatVinComand_Execute()
        {
            //nu reusesc sa afisez numele

            var canaMaxima = Cani.Where(k => k.UtilaPentru.Equals("Vin fiert") && k.SpalaInMasina.Equals(true)).OrderByDescending(k => k.Capacitate).FirstOrDefault();

            MessageBox.Show("Cana cu capacitatea cea mai mare care poate fi spalata la masina de tip vin fiert este " + canaMaxima.Nume + ".");
        }

        /*private void CeaMaiRecentaCanaDeCeaiIComand_Execute()
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
        }*/

        private void CeaMaiRecentaCanaDeCeaiIComand_Execute()
        {
            var ceaMaiRecentaCanaDeCeai = Cani.Where(k => k.UtilaPentru.Equals("Ceai")).OrderByDescending(k => k.DataFabricatiei).FirstOrDefault();
            MessageBox.Show("Cea mai recenta cana de ceai este: " + ceaMaiRecentaCanaDeCeai.Nume);
        }

        private void CanileIaurtComand_Execute()
        {
            // string canileIaurt = "";
            // string afisam = "";
            var toateCanileCuIaurt = Cani.Where(k => k.UtilaPentru.Equals("Iaurt")).Select(k => k.Nume);

            string afisam = String.Join(", ", toateCanileCuIaurt);

            /*foreach (CanaViewModel cana in Cani.ToList())
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
            }*/

            MessageBox.Show("Canile iaurt sunt: " + afisam);
        }


        private void AdaugaProducatorComand_Execute()
        {
            AdaugaProducatorViewModel adaugaProducatorViewModel = new AdaugaProducatorViewModel(this);

            AdaugaProducatorViewModel x = adaugaProducatorViewModel;

            adaugaProducatorViewModel.OkCommand = new DelegateCommand(adaugaProducatorViewModel.AdaugaProducator);

            Window fereastraNoua = new Window();
            fereastraNoua.Title = "Adauga un producator";
            fereastraNoua.MinWidth = 50;
            fereastraNoua.MinHeight = 50;
            fereastraNoua.Width = 500;
            fereastraNoua.Height = 500;
            fereastraNoua.Content = new AdaugaProducatorView();
            fereastraNoua.DataContext = adaugaProducatorViewModel;

            adaugaProducatorViewModel.Window = fereastraNoua;

            fereastraNoua.ShowDialog();
        }

        private void StergeProducatorComand_Execute()
        {
            if (Producatori.Count != 0)
            {
                Producatori.Remove(SelectedProducator);
            }
        }


        private void AdaugaMagazinComand_Execute()
        {
            AdaugaMagazinViewModel adaugaMagazinViewModel = new AdaugaMagazinViewModel(this);

            AdaugaMagazinViewModel x = adaugaMagazinViewModel;

            adaugaMagazinViewModel.OkCommand = new DelegateCommand(adaugaMagazinViewModel.AdaugaMagazin);

            Window fereastraNoua = new Window();
            fereastraNoua.Title = "Adauga un magazin";
            fereastraNoua.MinWidth = 50;
            fereastraNoua.MinHeight = 50;
            fereastraNoua.Width = 500;
            fereastraNoua.Height = 500;
            fereastraNoua.Content = new AdaugaMagazinView();
            fereastraNoua.DataContext = adaugaMagazinViewModel;

            adaugaMagazinViewModel.Window = fereastraNoua;

            fereastraNoua.ShowDialog();
        }

        private void StergeMagazinComand_Execute()
        {
            if (Magazine.Count != 0)
            {
                Magazine.Remove(SelectedMagazin);
            }
        }

        private void AdaugaFarfurieComand_Execute()
        {
            AdaugaFarfurieViewModel adaugaFarfurieViewModel = new AdaugaFarfurieViewModel(this);

            AdaugaFarfurieViewModel x = adaugaFarfurieViewModel;

            adaugaFarfurieViewModel.OkCommand = new DelegateCommand(adaugaFarfurieViewModel.AdaugaFarfurie);

            Window fereastraNoua = new Window();
            fereastraNoua.Title = "Adauga o Farfurie";
            fereastraNoua.MinWidth = 50;
            fereastraNoua.MinHeight = 50;
            fereastraNoua.Width = 500;
            fereastraNoua.Height = 500;
            fereastraNoua.Content = new AdaugaFarfurieView();
            fereastraNoua.DataContext = adaugaFarfurieViewModel;

            adaugaFarfurieViewModel.Window = fereastraNoua;

            fereastraNoua.ShowDialog();
        }

        private void StergeFarfurieComand_Execute()
        {
            if (Farfurii.Count != 0)
            {
                Farfurii.Remove(SelectedFarfurie);
            }
        }


        //cana cu numele cel mai lung care contine litera I
        private void CanaCeaMaiLungaCuI_Execute()
        {
            //var ceaMaiRecentaCanaDeCeai = Cani.Where(k => k.UtilaPentru.Equals("Ceai")).OrderByDescending(k => k.DataFabricatiei).FirstOrDefault();
            //MessageBox.Show("Cea mai recenta cana de ceai este: " + ceaMaiRecentaCanaDeCeai.Nume);
            var canaCeaMaiLungaCuI = Cani.Where(k => k.Nume.Contains("i")).OrderByDescending(k => k.Nume.Length).FirstOrDefault();
            MessageBox.Show("Cana cu numele cel mai lung care contine litera I este " + canaCeaMaiLungaCuI.Nume + ".");
        }

        private void CelMaiLungNumeDeFarfurieComand_Execute()
        {
            var celMaiLungNumeDeFarfurie = Farfurii.OrderByDescending(k => k.Nume.Length).FirstOrDefault();
            MessageBox.Show("Farfuria cu numele cel mai lung este" + celMaiLungNumeDeFarfurie.Nume + ".");
        }

        //afiseaza lista de farfurii cu stoc mai mare de 50
        private void MaiMultDe50FarfuriiComand_Execute()
        {
            var stocMaiMareDe50 = Farfurii.Where(k => k.Stoc > 50).Select(k => k.Nume);
            string afisam = String.Join(", ", stocMaiMareDe50);
            MessageBox.Show("Farfuriile cu stocuri mai mari de 50 sunt " + afisam + ".");
        }

        private void CelMaiLungNumeDeFarfurieCuHComand_Execute()
        {
            var celMaiLungNumeDeFarfurieCuH = Farfurii.Where(k => k.Nume.Contains("h")).OrderByDescending(k => k.Nume.Length).FirstOrDefault();

            if (celMaiLungNumeDeFarfurieCuH != null)
            {
                MessageBox.Show("Farfura cu cel mai lung nume care contine litera H este " + celMaiLungNumeDeFarfurieCuH.Nume + ".");
            }
            else
            {
                MessageBox.Show("Nu exista farfurii care indeplinesc aceste conditii");
            }
        }

        // farfuria gri cu numele cel mai lung
        private void CeaMaiLungaFarfurieGriComand_Execute()
        {
            var ceaMaiLungaFarfuGri = Farfurii.Where(k => k.Nume.Contains("gri")).OrderByDescending(k => k.Nume.Length).FirstOrDefault();
            MessageBox.Show("Farfuria gri cu numele cel mai lung este " + ceaMaiLungaFarfuGri.Nume + ".");
        }

        //numele si numarul de telefon, daca producatorul e romanesc
        public void NumeNumarRoComand_Execute()
        {
            var numeNumarRo = Producatori.Where(k => k.TaraDeOrigine.Equals("Romania")).Select(k => k.Nume + " " + k.NumarDeTelefon);
            var final = string.Join(", ", numeNumarRo);
            MessageBox.Show("Numele si numarul de telefon al producatorilor din Romania este: " + final + ".");
        }

        //farfura cu diametrul cel mai mare cu stoc peste 100
        public void DiametruMareStoc100Comand_Execute()
        {
            var diametruStoc100 = Farfurii.Where(k => k.Diametru > 100).OrderByDescending(k => k.Diametru).FirstOrDefault();
            MessageBox.Show("Farcuria cu diametrul cel mai mare cu stoc peste 100 este " + diametruStoc100.Nume + ".");
        }

        //farfuria gri cu cel mai mic diametru cu stoc mai mare de 100
        public void DMicGri100Comand_Execute()
        {
            var dMicGri100 = Farfurii.Where(k => k.Culoare.Equals("gri") && k.Stoc>100 ).OrderBy(k => k.Diametru).LastOrDefault();
            MessageBox.Show("Farfuria gri cu cel mai mic diametru cu stoc mai mare de 100 este " + dMicGri100.Nume + ".");
        }
    }
}
