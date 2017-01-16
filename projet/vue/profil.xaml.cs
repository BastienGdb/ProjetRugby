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
    /// Logique d'interaction pour profil.xaml
    /// </summary>
    public partial class profil : UserControl
    {
        private Manager Manager
        {
            get;
            set;
        }
        public profil(Manager Manager,UtilisateurInscrit user)
        {
            this.Manager = Manager;
            InitializeComponent();
            pseudo.Text = user.Pseudo;
            sexe.Text = Utils.SexeToString[user.Sexe];
            if (user.EquipeFavorite == null)
            {
                equipefav.Text = "aucune";
            }
            else
            {
                equipefav.Text = user.EquipeFavorite.Nom;
            }
            if (user.EquipeNationalFavorite == null)
            {
                equipenatfav.Text = "aucune";
            }
            else
            {
                equipenatfav.Text = user.EquipeNationalFavorite.Nom;
            }
        }
        public profil(Manager Manager, Moderateur modo)
        {
            this.Manager = Manager;
            InitializeComponent();
            pseudo.Text = modo.Pseudo;
            sexe.Text = "nom renseigné";
            equipefav.Text = "aucune";
            equipefav.Text = "aucune";
            equipenatfav.Text = "aucune";
        }
    }
}
