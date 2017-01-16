using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using métier;
namespace vue
{
    /// <summary>
    /// Cette classe est une fabrique de Controle utilisateur
    /// </summary>
   public static class DetailUserControlFactory
    {
        /// <summary>
        /// Cette méthode va retourner le Controle Utilisateur qui correspond à la compétition.
        /// </summary>
        /// <param name="compet"></param>
        /// <returns></returns>
        public static System.Windows.Controls.UserControl CreatDetailUserControl(Competition compet,MainWindow m,Manager manager)
        {
            if (compet is CompetitionPouleUnique)
            {
                return new competition(compet, m,manager);
            }
            else if (compet is CompetitionAPoule)
            {
                return new UCCompetitionAPoule(compet, m,manager);
            }

            return null;
        }
    }
}
