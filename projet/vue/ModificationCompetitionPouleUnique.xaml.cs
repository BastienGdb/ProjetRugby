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
    /// Logique d'interaction pour ModificationCompetitionPouleUnique.xaml
    /// </summary>
    public partial class ModificationCompetitionPouleUnique : UserControl
    {
        Manager Manager;
        MainWindow m;
        CompetitionPouleUnique compet;
        public ModificationCompetitionPouleUnique(Manager manager, MainWindow mw , CompetitionPouleUnique c)
        {
            InitializeComponent();
            Manager = manager;
            m = mw;
            compet = c;
            DataContext = Manager;
        }

        public void retour(object sender, RoutedEventArgs e)
        {
            var UC = new AccueilModerateur(m, Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        public void AjouterEquipe(object sender, RoutedEventArgs e)
        {
            var UC = new CreationEquipe(Manager, m, compet);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }

        public void SupprimerEquipe(object sender, RoutedEventArgs e)
        {
            
            string s = comboboxEquipe.Text;
            foreach(Equipe eq in Manager.EquipeCompetROC)
            {
                if (eq.ToString().Equals(s))
                {
                    var UC = new AccueilModerateur(m, Manager);
                    m.mGridCentre.Children.Clear();
                    m.mGridCentre.Children.Add(UC);
                }
            }

            }
        }
}
