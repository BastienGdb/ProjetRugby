using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
    /// <summary>
    /// Cette classe va être appelé lorsque l'on veut mettre à jour les points d'une équipe.
    /// Elle contient une seule méthode qui "fabrique" la façon dont on mettra à jour les points.
    /// </summary>
    public class FabriqueMajPoints
    {
        /// <summary>
        /// Cette méthode ne met pas à jour elle même les points d'une équipe.
        /// Elle va regarderla compétition passés en paramètres et ainsi retourner une instance de la bonne classe que l'on devra utilisé. 
        /// 
        /// </summary>
        /// <param name="compet">compétition</param>
        /// <returns>retourne une classe qui implémente l'inteface IMAJ_Points. </returns>
        public IMAJ_Points FabriqueMaj(Competition compet)
        {
            
            if (compet.Nom.Equals("top 14")&& compet.Nom.Equals("pro D2"))
            {
                return new MajPointsChampionnatFrancais();
            }
            else
            {
                return new MajPointsAutreChampionnat();
            }

        }
    }
}
