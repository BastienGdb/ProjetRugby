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
    /// Logique d'interaction pour UCCalendrier.xaml
    /// </summary>
    public partial class UCCalendrier : UserControl
    {
        private Manager Manager
        {
            get;
            set;
        }
        MainWindow m;
        Competition c;
        Equipe equipe;
        public UCCalendrier(Manager manager, MainWindow m , Equipe e,Competition c)
        {
            this.c = c;
            equipe = e;
            this.m = m;
            Manager = manager;
            InitializeComponent();
            DataContext = manager;
            nomEquipe.Text = e.Nom;
            manager.ChargeMatchsEquipe(e);
            image.Source = new BitmapImage(new Uri(e.CheminLogo, UriKind.Relative));

        }

        private void retour(object sender, RoutedEventArgs e)
        {
            var UC = new UCEquipe(equipe, m, c, Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);
        }
    }
}
