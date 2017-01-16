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
using métier;

namespace vue
{
    /// <summary>
    /// Logique d'interaction pour UCPalmares.xaml
    /// </summary>
    public partial class UCPalmares : UserControl
    {
        private Manager Manager { get; set; }
        Competition c;
        Equipe equipe;
        MainWindow m;
        public UCPalmares(Manager Manager, Equipe e, MainWindow m, Competition c)
        {
            InitializeComponent();
            this.Manager = Manager;
            this.c = c;
            equipe = e;
            this.m = m;
            DataContext = Manager;
            Manager.ChargeTropheEquipe(e);
            image.Source = new BitmapImage(new Uri(e.CheminLogo, UriKind.Relative));   
        }

        private void retour(object sender, RoutedEventArgs r)
        {
            var UC = new UCEquipe(equipe, m, c, Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

    }
}
