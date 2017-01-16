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
    /// Logique d'interaction pour UCHistoriqueCompetition.xaml
    /// </summary>
    public partial class UCHistoriqueCompetition : UserControl
    {

        private Manager Manager { get; set; }
        Competition c;
        MainWindow m;

        public UCHistoriqueCompetition(Competition c, MainWindow m, Manager manager)
        {
            InitializeComponent();
            this.Manager = manager;
            this.c = c;
            this.m = m;
            DataContext = Manager;
            Manager.ChargeTropheCompetition(c);
        }

        private void retour(object sender, RoutedEventArgs r)
        {
            m.mGridCentre.Children.Clear();
            if (c is CompetitionAPoule)
            {
                m.mGridCentre.Children.Add( new UCCompetitionAPoule(c as CompetitionAPoule, m, Manager));
            }else
            {
                m.mGridCentre.Children.Add(new competition(c as CompetitionPouleUnique, m, Manager));
            }
        }
    }
}
