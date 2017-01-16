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
using System.Windows.Shapes;
using métier;
namespace vue
{
    /// <summary>
    /// Logique d'interaction pour connexion.xaml
    /// </summary>
    public partial class connexion : Window
    {

        private Manager Manager
        {
            get;
            set;
        }
        public connexion(Manager Manager)
        {
            InitializeComponent();
            this.Manager = Manager;

        }

        private void Button_Click_Accueil(object sender, RoutedEventArgs e)
        {
            var c = new MainWindow();
            c.Show();
            this.Close();
        }

        /// <summary>
        // Lorsque que l'on clique sur le bouton valider c'est cette méthode qui est appelée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seconnecter(object sender, RoutedEventArgs e)
        {
            if (Manager.seconnecter(login.Text, mdp.Password) == true)
            {
                var c = new MainWindow();
                this.Close();
                c.Show();
                c.mGridCentre.Children.Clear();
                if(Manager.Retourneutilisateur(login.Text, mdp.Password) is Moderateur)
                {
                    var UC = new AccueilModerateur(c, Manager);
                    c.mGridCentre.Children.Clear();
                    c.mGridCentre.Children.Add(UC);
                }else
                {
                    Manager.CurrentUser = Manager.Retourneutilisateur(login.Text, mdp.Password);
                    c.mGridCentre.Children.Add(new profil(Manager, Manager.Retourneutilisateur(login.Text, mdp.Password)));
                }

            }
            else
            {
                MessageBox.Show("Mot de passe ou login incorrects");
            }
        }

        /// <summary>
        /// Lorsque l'on clique sur le lien c'est cette méthode qui nous redirige vers la page d'inscription.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inscription(object sender, RoutedEventArgs e)
        {
            var c = new Inscription(Manager);
            this.Close();
            c.Show();

        }

    }
}
