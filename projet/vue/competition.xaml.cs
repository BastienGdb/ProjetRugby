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
    /// Logique d'interaction pour competition.xaml
    /// </summary>
    public partial class competition : UserControl
    {

        private Manager Manager
        {
            get;
            set;
        }
        MainWindow m;
        Competition compet;
        public competition(Competition compet,MainWindow  m,Manager Manager)
        {
            InitializeComponent();
            this.Manager = Manager; 
            DataContext = Manager;
            Manager.ChargeEquipe(compet.Nom);
            nomcompet.Text=compet.Nom;
            descriptioncompet.Text = compet.Description;
            image.Source = new BitmapImage(new Uri(compet.CheminLogo, UriKind.Relative));
            this.m = m;
            this.compet = compet;
        }

        private void selectionEquipe(object sender, SelectionChangedEventArgs e)
        {
            // On prend l'Item sélectionné de la List view
            var equipe = ((sender as ListView).SelectedItem as Equipe);
            var UC = new UCEquipe(equipe, m, compet,Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);

        }

        private void historique (object sender, RoutedEventArgs e)
        {
            var UC = new UCHistoriqueCompetition(compet, m ,Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }


        private void calendrier(object sender, RoutedEventArgs e)
        {
            var UC = new UCCalendrierCompetition(compet, Manager, m);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        private void classement(object sender, RoutedEventArgs e)
        {
            var UC = new UCClassement(Manager, compet as CompetitionPouleUnique, m);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }
    }
}
