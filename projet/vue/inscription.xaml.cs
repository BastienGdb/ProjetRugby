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
    /// Logique d'interaction pour Inscription.xaml
    /// </summary>
    public partial class Inscription : Window
    {
        private Manager Manager
        {
            get;
            set;
        }
        public string Login { get; set; }
        public string mdp { get; set; }
        public string mdp2 { get; set; }
        public string sexe { get; set; }
        public string equipefav { get; set; }
        public string equipenatfav { get; set; }
        public Sexe s { get; set; }

        public Inscription(Manager Manager)
        {
            InitializeComponent();
            this.Manager = Manager;
            DataContext = Manager;
            Manager.ChargeEquipeNat();
            Manager.ChargeAllEquipe();
        }

        private void Button_Click_Accueil(object sender, RoutedEventArgs e)
        {
            var c = new MainWindow();
            c.Show();
            this.Close();
        }

        private void validerinscription(object sender, RoutedEventArgs e)
        {
            Login = login.Text;
            mdp = password.Password;
            mdp2 = password2.Password;
            sexe = sex.Text;
            // comboboxequipe.text retourne un string avec le nom et la descrition de l'équipe comment faire?
            equipefav = comboboxequipe.Text;
            equipenatfav = comboboxequipenat.Text;

            if(Login.Equals("") || mdp.Equals(""))
            {
                MessageBox.Show("Champs vide");
                return;
            }
            if (sexe.Equals("Homme"))
            {
                s = Sexe.Homme;
            }
            else
            {
                s = Sexe.Femme;
            }
            if (mdp.Equals(mdp2))
            {
                if (Manager.InscriptionUser(mdp, Login, s, equipefav, equipenatfav) == true)
                {
                    var c = new connexion(Manager);
                    c.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Utilisateur déja existant");
                }
            }
            else
            {
                MessageBox.Show("Les deux mots de passe ne correspondent pas");

            }



        }
    }
}
