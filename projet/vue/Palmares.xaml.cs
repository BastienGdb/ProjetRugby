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
    /// Logique d'interaction pour Palmares.xaml
    /// </summary>
    public partial class Palmares : UserControl
    {
        private Manager Manager
        {
            get;
            set;
        }
        public Palmares(Manager Manager, Equipe e)
        {
            InitializeComponent();
            this.Manager = Manager;


        }
    }
}
