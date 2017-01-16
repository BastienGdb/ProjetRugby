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
    /// Logique d'interaction pour CreationCompetition.xaml
    /// </summary>
    public partial class CreationCompetition : UserControl
    {
        Manager Manager;
        MainWindow m;
        public CreationCompetition(Manager manager, MainWindow mw)
        {
            Manager = manager;
            m = mw;
            DataContext = Manager;
            InitializeComponent();
        }

        private void retour (object sender, RoutedEventArgs e)
        {
            var UC = new AccueilModerateur(m, Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }
    }
}
