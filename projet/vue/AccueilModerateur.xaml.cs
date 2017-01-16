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
    /// Logique d'interaction pour AccueilModerateur.xaml
    /// </summary>
    public partial class AccueilModerateur : UserControl
    {
        private Manager manager { get; set; }
        MainWindow m;
        public AccueilModerateur(MainWindow mw, Manager Manager)
        {
            InitializeComponent();
            m = mw;
            manager = Manager;
            manager.ChargeCompetition();
            DataContext = manager;
        }

        private void retour(object sender, RoutedEventArgs e)
        {
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(new Accueil());
        }

        private void ajouterCompetition(object sender, RoutedEventArgs e)
        {
            var UC = new CreationCompetition(manager, m);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        private void ajouterTrophes(object sender, RoutedEventArgs e)
        {
            var UC = new CreationTrophes(manager, m);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        private void ajouterMatch(object sender, RoutedEventArgs e)
        {
            var UC = new CréationMatch(manager, m);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        private void ajouterJoueur(object sender, RoutedEventArgs e)
        {
            var UC = new CreationJoueur(manager, m);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }
        string nomCompet;
        public void ModifCompet(object sender, RoutedEventArgs e)
        {
            nomCompet = comboboxCompetition.Text;
            foreach(Competition c in manager.CompetitionsROC)
            {
                if (c.ToString().Equals(nomCompet))
                {
                    if(c is CompetitionAPoule)
                    {
                        var UC = new ModificationCompétitionAPoule( manager, m, c as CompetitionAPoule);
                        m.mGridCentre.Children.Clear();
                        m.mGridCentre.Children.Add(UC);
                    }
                    else
                    {
                        var UC = new ModificationCompetitionPouleUnique(manager, m, c as CompetitionPouleUnique);
                        m.mGridCentre.Children.Clear();
                        m.mGridCentre.Children.Add(UC);
                    }
                }
            }
        }

    }
}
