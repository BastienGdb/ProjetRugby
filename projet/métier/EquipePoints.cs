using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
    /// <summary>
    /// cette classe est utilisée dans la classe CompetitionPouleUnique pour permettre le tri du classement.
    /// </summary>
    public class EquipePoints : IEquatable<EquipePoints>
    {
        /// <summary>
        /// Equipe en question 
        /// </summary>
        public Equipe Equipe { get; set; }
        /// <summary>
        /// nombre de points de cette équipe
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// vérifie que "right" est une équipePoints
        /// </summary>
        /// <param name="right">objet comparer avec équipePoints</param>
        /// <returns>vrai si c'est égal, faux sinon</returns>
        public override bool Equals(object right)
        {
            //check null
            if (object.ReferenceEquals(right, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))
            {
                return true;
            }

            if (this.GetType() != right.GetType())
            {
                return false;
            }

            return this.Equals(right as EquipePoints);
        }

        /// <summary>
        /// retourne le hash code
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return Equipe.GetHashCode();
        }

        /// <summary>
        /// méthode Equals de la classe EquipePoints
        /// </summary>
        /// <param name="equipe">équipe que l'on souhaite comparer</param>
        /// <returns>true or false</returns>
        public bool Equals(EquipePoints equipe)
        {
            if (this.Equipe.Equals(equipe.Equipe))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
