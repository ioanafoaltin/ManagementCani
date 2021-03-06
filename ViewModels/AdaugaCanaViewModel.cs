﻿using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Cana.ViewModels
{
    class AdaugaCanaViewModel
    {
        private String _nume;

        public string Nume
        {
            get { return _nume; }
            set
            {
                _nume = value;

                //OkCommand.RaiseCanExecuteChanged();
            }
        }

        public int _capacitate;

        public int Capacitate
        {
            get { return _capacitate; }
            set
            {
                _capacitate = value;
            }
        }

        public DateTime _dataFabricatiei;

        public DateTime DataFabricatiei
        {
            get { return _dataFabricatiei; }
            set { _dataFabricatiei = value; }
        }

        public bool _spalaInMasina;

        public bool SpalaInMasina
        {
            get { return _spalaInMasina; }
            set { _spalaInMasina = value; }
        }

        public String _utilaPentru;

        public string UtilaPentru
        {
            get { return _utilaPentru; }
            set { _utilaPentru = value; }
        }

        public int _stoc;

        public int Stoc
        {
            get { return _stoc; }
            set { _stoc = value; }
        }


        public DelegateCommand OkCommand { get; set; }
        public MainViewModel MainViewModel { get; internal set; }
        public Window Window { get; internal set; } //ca sa am cum sa inchid fereastra cand dau pe ok


        public AdaugaCanaViewModel(MainViewModel mainVM)
        {
            MainViewModel = mainVM;

            ToateValorilePosibilePentruUtilePentru = new ObservableCollection<string>();
            ToateValorilePosibilePentruUtilePentru.Add("Cafea");
            ToateValorilePosibilePentruUtilePentru.Add("Ceai");
            ToateValorilePosibilePentruUtilePentru.Add("Vin fiert");
            ToateValorilePosibilePentruUtilePentru.Add("Lapte");
            ToateValorilePosibilePentruUtilePentru.Add("Cacao");
            ToateValorilePosibilePentruUtilePentru.Add("Iaurt");
        }

        public void AdaugaCana()
        {
            // incearca sa intelegi cum functioneaza adaugarea, prin schema:
            CanaViewModel canaNoua = new CanaViewModel();
            canaNoua.MainViewModel = MainViewModel;
            canaNoua.Nume = Nume;
            canaNoua.Capacitate = Capacitate;
            canaNoua.DataFabricatiei = DataFabricatiei;
            canaNoua.SpalaInMasina = SpalaInMasina;
            canaNoua.UtilaPentru = UtilaPentru;
            canaNoua.Stoc = Stoc;


            MainViewModel.Cani.Add(canaNoua);

            Window.Close();
        }

        public ObservableCollection<string> ToateValorilePosibilePentruUtilePentru { get; set; }



    }
}
