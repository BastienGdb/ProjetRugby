using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
    [DataContract]
    public class Commentaire :IEquatable<Commentaire>
    {
        /// <summary>
        /// message que l'utilisateur a écrit
        /// </summary>
        [DataMember]
        public String Message { get; private set; }
        /// <summary>
        /// Auteur du commentaire
        /// </summary>
        [DataMember]
        public UtilisateurInscrit Auteur { get; private set; }
        /// <summary>
        /// Date du commentaire
        /// </summary>
        [DataMember]
        public DateTime Date { get; private set; }

        /// <summary>
        /// Constructeur de commentaire
        /// </summary>
        /// <param name="message"> message du commentaire</param>
        /// <param name="date">date du commentaire</param>
        /// <param name="auteur"> auteur du commentaire</param>
        public Commentaire(String message, DateTime date, UtilisateurInscrit auteur)
        {
            Message = message;
            Date = date;
            Auteur = auteur;
        }

        /// <summary>
        /// vérifie que "right" est un commentaire
        /// </summary>
        /// <param name="right">objet comparer avec commentaire</param>
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

            return this.Equals(right as Commentaire);
        }

        /// <summary>
        /// retourne le hash code
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return Message.GetHashCode() + Date.GetHashCode();
        }
        public bool Equals(Commentaire c)
        {
            if(Message.Equals(c.Message) && Date.Equals(c.Date) && Auteur.Equals(c.Auteur))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// métode ToString de la classe Commentaire
        /// </summary>
        /// <returns>retourne un string comprenant le pseudo de l'auteur, la date et le commentaire.</returns>
        public override string ToString()
        {
             return "\n"+ Auteur.Pseudo +" " + Date.ToString() + " " +Message;
        }
    }
}
