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
using projet;

namespace vue
{
    /// <summary>
    /// Logique d'interaction pour UCCompetitionAPoule.xaml
    /// </summary>
    public partial class UCCompetitionAPoule : UserControl
    {
        private Manager Manager
        {
            get;
            set;
        }
        MainWindow m;
        Competition c;
        public UCCompetitionAPoule(Competition compet,MainWindow m,Manager Manager)
        {
            InitializeComponent();
            this.Manager = Manager;
            DataContext = Manager;
            Manager.ChargeCompetitionAPoule(compet.Nom);
            nomcompet.Text = compet.Nom;
            descriptioncompet.Text = compet.Description;
            image.Source = new BitmapImage(new Uri(compet.CheminLogo, UriKind.Relative));
            this.m = m;
            c = compet;
        }

        private void selectionPoule(object sender, SelectionChangedEventArgs e)
        {
            var compet = ((sender as ListView).SelectedItem as Competition);
            var UC = DetailUserControlFactory.CreatDetailUserControl(compet, m,Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        private void historique(object sender, RoutedEventArgs e)
        {
            var UC = new UCHistoriqueCompetition(c, m, Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        private void calendrier( object sender, RoutedEventArgs e)
        {
            var UC = new UCCalendrierCompetition(c, Manager, m);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }
    }
}
