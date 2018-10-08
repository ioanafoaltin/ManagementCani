using Cana.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cana
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // ca sa legi MainWindow de MainViewModel:
            DataContext = new MainViewModel();

            // NU se mai adauga alt cod in fisieru asta. Orice eveniment care vroiai sa il adaugi aici, va avea o comanda in MainViewModel
        }
    }
}
