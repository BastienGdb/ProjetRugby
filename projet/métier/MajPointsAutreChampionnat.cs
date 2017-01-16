using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
    /// <summary>
    /// Classe qui implémente l'interface IMAJ_Points
    /// </summary>
    public class MajPointsAutreChampionnat : IMAJ_Points
    {

        /// <summary>
        /// Selon le championnat, cette méthode sera différente et permettra de mettre à jour les points d'une équipe.
        /// </summary>
        /// <param name="compet">Compétition</param>
        /// <param name="m">match</param>
        /// <param name="res">résultat</param>
        public void MajPoints(CompetitionPouleUnique compet, Match m)
        {
            int NbPtsA = 0;
            int NbPtsB = 0;

            if (m.res.scoreEquipeA == m.res.scoreEquipeB)
            {
                NbPtsA = 2;
                NbPtsB = 2;
            }
            else if (m.res.scoreEquipeA > m.res.scoreEquipeB)
            {
                NbPtsA = 4;
                if (m.res.scoreEquipeA - m.res.scoreEquipeB <= 7)
                {
                    NbPtsB += 1;
                }
            }
            else
            {
                NbPtsB = 4;
                if (m.res.scoreEquipeB - m.res.scoreEquipeA <= 7)
                {
                    NbPtsA += 1;
                }
            }


            if (m.res.nbEssaiEquipeA >= 4)
            {
               NbPtsA += 1;
            }
            else if (m.res.nbEssaiEquipeB >= 4)
            {
                NbPtsB += 1;
            }



            compet.AjouterPointEquipe(m.EquipeA, NbPtsA);
            compet.AjouterPointEquipe(m.EquipeB, NbPtsB);
        }
    }
}
