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
    /// Logique d'interaction pour UCEquipe.xaml
    /// </summary>
    public partial class UCEquipe : UserControl
    {

        private Manager Manager
        {
            get;
            set;
        }
        MainWindow m;

        Equipe equipe;

        Competition compet;
        public UCEquipe(Equipe equipe, MainWindow m,Competition compet,Manager Manager)
        {
            this.Manager = Manager;
            InitializeComponent();
            DataContext = Manager;
            Manager.ChargeEffectif(equipe);
            nomEquipe.Text = equipe.Nom;
            description.Text = equipe.Description;
            this.m = m;
            this.compet = compet;
            this.equipe = equipe;
            if (equipe.CheminLogo == null)
            {
                image.Source = new BitmapImage(new Uri("Images/logoinconnue.png", UriKind.Relative));

            }
            else
            {
                image.Source = new BitmapImage(new Uri(equipe.CheminLogo, UriKind.Relative));
            }
        }

        private void retour(object sender, RoutedEventArgs e)
        {
            var UC = DetailUserControlFactory.CreatDetailUserControl(compet, m,Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        private void selectionjoueur(object sender, SelectionChangedEventArgs e)
        {
            // On prend l'Item sélectionné de la List view
            var joueur = ((sender as ListView).SelectedItem as Joueur);
            var UC = new UCJoueur(joueur, m,compet,Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        private void calendrierEquipe ( object sender, RoutedEventArgs e)
        {
            var UC = new UCCalendrier(Manager, m, equipe, compet);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        private void resultatsEquipe( object sender, RoutedEventArgs e)
        {
            var UC = new Resultat(Manager, m, equipe, compet);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        private void palmaresEquipe(object sender, RoutedEventArgs e)
        {
            var UC = new UCPalmares(Manager, equipe, m, compet);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }
    }
}
