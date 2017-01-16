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
    /// Logique d'interaction pour Resultat.xaml
    /// </summary>
    public partial class Resultat : UserControl
    {
        private Manager Manager
        {
            get;
            set;
        }
        MainWindow m;
        Equipe equipe;
        Competition compet; 

        public Resultat(Manager manager, MainWindow m, Equipe e, Competition c)
        {
            InitializeComponent();
            Manager = manager;
            DataContext = Manager;
            this.m = m;
            equipe = e;
            Manager.ChargerResultatsEquipe(equipe);
            compet = c;
            image.Source = new BitmapImage(new Uri(e.CheminLogo, UriKind.Relative));
        }


        private void retour(object sender, RoutedEventArgs r)
        {
            var UC = new UCEquipe(equipe, m, compet, Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

    }
}
