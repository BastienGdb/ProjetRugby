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
using Persistance;


namespace vue
{

   
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Manager Manager
        {
            get;
            set;
        }

        public MainWindow()
        {
            InitializeComponent();
            mGridCentre.Children.Add(new Accueil());
            Manager = new Manager(new StubDataManager());
            Manager.ChargeCompetition();
            DataContext = Manager;
        }

       
        private void Button_Click_Accueil(object sender, RoutedEventArgs e)
        {
            mGridCentre.Children.Clear();
            mGridCentre.Children.Add(new Accueil());
        }

        private void Button_Click_Connexion(object sender, RoutedEventArgs e)
        {
            var c = new connexion(Manager);
            this.Close();
            c.Show();
            
        }

        private void selectioncompet(object sender, SelectionChangedEventArgs e)
        {
            // On prend l'Item sélectionné de la List view et on appelle la fabrique de controle utilisateur
            var compet = ((sender as ListView).SelectedItem as Competition);
            var UC = DetailUserControlFactory.CreatDetailUserControl(compet, this,Manager);
            mGridCentre.Children.Clear();
            mGridCentre.Children.Add(UC);            
        }

       private void acceuilModerateur(object sender, RoutedEventArgs e)
        {
            if(Manager.CurrentUser is Moderateur)
            {
                var UC = new AccueilModerateur(this, Manager);
                mGridCentre.Children.Clear();
                mGridCentre.Children.Add(UC);
                
            }else if(Manager.CurrentUser is UtilisateurInscrit)
            {
                MessageBox.Show("Accès refusé, vous n'etes pas Modérateur");
            }
            else
            {
                var UC = new connexion(Manager);
                this.Close();
                UC.Show();
            }
        }
            
        
    }
}
