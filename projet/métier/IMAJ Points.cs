using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
    /// <summary>
    /// Interface qui est implémentée par différentes classes correpondantes à différents championnats.
    /// </summary>
    public interface IMAJ_Points
    {
        /// <summary>
        /// Selon le championnat, cette méthode sera différente et permettra de mettre à jour les points d'une équipe.
        /// </summary>
        /// <param name="compet">Compétition</param>
        /// <param name="m">match</param>
        /// <param name="res">résultat</param>
        void MajPoints(CompetitionPouleUnique compet,Match m);
    }
}
