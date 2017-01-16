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
    /// Logique d'interaction pour ModificationCompétitionAPoule.xaml
    /// </summary>
    public partial class ModificationCompétitionAPoule : UserControl
    {
        Manager Manager;
        MainWindow m;
        CompetitionAPoule compet;
        public ModificationCompétitionAPoule(Manager manager, MainWindow mw , CompetitionAPoule c)
        {
            InitializeComponent();
            Manager = manager;
            m = mw;
            compet = c;
            DataContext = Manager;
        }
    }
}
