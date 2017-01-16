using System;
using métier;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace métier
{
    [DataContract]
    public class Trophes : IEquatable<Trophes>
    {
        /// <summary>
        /// Nom du trophé en question
        /// </summary>
        [DataMember]
        public string NomTrophe { get; private set; }
        /// <summary>
        /// Date de l'obtention de ce trophé
        /// </summary>
        [DataMember]
        public int Date { get; set; }
        /// <summary>
        /// Nom de la compétition qui correspond à ce trophé
        /// </summary>
        [DataMember]
        public Competition NomCompet { get; private set; }

        [DataMember]
        public Equipe EquipeGagnante { get; private set; }
        /// <summary>
        /// Constructeur de trophé
        /// </summary>
        /// <param name="nomCompet">nom de la compétition remporté</param>
        /// <param name="date">date du sacre</param>
        /// <param name="nomTrophe">nom du trophé</param>
        /// <param name="e">equipe qui a gagné</param>
        public Trophes(Competition nomCompet, int date, string nomTrophe, Equipe e)
        {
            NomCompet = nomCompet;
            Date = date;
            NomTrophe = nomTrophe;
            EquipeGagnante = e;
        }

        
        /// <summary>
        /// vérifie que "right" est un trophé
        /// </summary>
        /// <param name="right">objet comparer avec Trophé</param>
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

            return this.Equals(right as Trophes);
        }

        /// <summary>
        /// retourne le hash code
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return NomCompet.GetHashCode() + NomTrophe.GetHashCode() + Date.GetHashCode();
        }

        /// <summary>
        /// Methode permettant de comparer deux trophés
        /// </summary>
        /// <param name="t">trophé que l'on veut comparer</param>
        /// <returns>vrai ou faux</returns>
        public bool Equals(Trophes t)
        {
            if (this.NomTrophe.Equals(t.NomTrophe) && this.NomCompet.Equals(t.NomCompet) && this.Date.Equals(t.Date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Méthode ToString
        /// </summary>
        /// <returns>retourne un string qui donne les principaux éléments de la classe.</returns>
        public override string ToString()
        {
            string t = NomTrophe + NomCompet + Date.ToString();
            return t;
        }

    }
}
