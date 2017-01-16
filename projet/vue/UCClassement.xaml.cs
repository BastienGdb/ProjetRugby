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
    /// Logique d'interaction pour UCClassement.xaml
    /// </summary>
    public partial class UCClassement : UserControl
    {
        Manager Manager;
        CompetitionPouleUnique c;
        MainWindow m;
        public UCClassement(Manager manager, CompetitionPouleUnique compet, MainWindow mw)
        {
            InitializeComponent();
            Manager = manager;
            c = compet;
            m = mw;
            DataContext = Manager;
            Manager.ChargeClassementCompetition(c);
        }

        private void retour(object sender, RoutedEventArgs r)
        {
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(new competition(c as CompetitionPouleUnique, m, Manager));
        }
    }
}
