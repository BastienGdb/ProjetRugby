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
    /// Logique d'interaction pour UCJoueur.xaml
    /// </summary>
    public partial class UCJoueur : UserControl
    {
        private Manager Manager
        {
            get;
            set;
        }
        MainWindow m;
        Competition c;
        Joueur j;
        public UCJoueur(Joueur j, MainWindow m, Competition compet,Manager Manager)
        {
            c = compet;
            this.j = j;
            InitializeComponent();
            this.Manager = Manager;
            DataContext = Manager;
            this.m = m;
            nom.Text = j.Nom;
            prenom.Text = j.Prenom;
            string selectionString;
            selectionString = Convert.ToString(j.Selection);
            selection.Text = selectionString;
            string poidString;
            poidString = Convert.ToString(j.Poids);
            if (poidString.Equals("0"))
            {
                poid.Text = "Poids inconnue";
            }else
            {
                poid.Text = poidString;

            }
            string tailleString;
            tailleString = Convert.ToString(j.Taille);
            if (tailleString.Equals("0"))
            {
                taille.Text = "Taile inconnue";
            }
            else
            {
                taille.Text = tailleString;

            }
            equipeActuelle.Text = j.EquipeActuelle.Nom;
            Nationalite.Text = j.Nationalite;
            poste.Text = Utils.PosteToString[j.PosteJoueur];

            if (j.Photo == null)
            {
                image.Source = new BitmapImage(new Uri("/Images/joueur/inconnue.jpg", UriKind.Relative));

            }
            else
            {
                image.Source = new BitmapImage(new Uri(j.Photo, UriKind.Relative));

            }
        }

        private void retour(object sender, RoutedEventArgs e)
        {
            var UC = new UCEquipe(j.EquipeActuelle, m, c,Manager);
            m.mGridCentre.Children.Clear();
            m.mGridCentre.Children.Add(UC);

        }
    }

}
