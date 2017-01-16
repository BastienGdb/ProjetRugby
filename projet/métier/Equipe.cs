using System;
using métier;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace métier
{
    [DataContract]
    public class Equipe :IEquatable<Equipe> 
    {
        /// <summary>
        /// Nom de l'équipe
        /// </summary>
        [DataMember]
        public string Nom { get; private set; }
        /// <summary>
        /// Type de l'équipe (Nationale ou club)
        /// </summary>
        [DataMember]
        public TypeEquipe Type { get; private set; }
        /// <summary>
        /// Chemin vers une video de l'hymne de cette équipe
        /// </summary>
        public string Hymne { get; private set; }
        /// <summary>
        /// Chemin vers le logo de cette équipe
        /// </summary>
        [DataMember]
        public string CheminLogo { get; private set; }
        /// <summary>
        /// Description de l'équipe
        /// </summary>
        [DataMember]
        public string Description { get; private set; }
        /// <summary>
        /// Liste des joueurs de cette équipe
        /// </summary>
        internal List<Joueur> Effectif { get; set; } = new List<Joueur>();
        /// <summary>
        /// Liste des commentaires laissés par les différents utilisateurs pour une équipe
        /// </summary>
        [DataMember]
        internal List<Commentaire> Commentaires { get;  set; } = new List<Commentaire>();
        /// <summary>
        /// Liste des trophés qu'une équipe a remporté
        /// </summary>
        internal List<Trophes> Palmares { get; set; } = new List<Trophes>();
        

        /// <summary>
        /// Constructeur avec tous les paramètres
        /// </summary>
        /// <param name="nom">nom de l'équipe</param>
        /// <param name="type">type de l'équipe</param>
        /// <param name="description">Description de l'équipe</param>
        /// <param name="cheminLogo">Chemin d'accès au logo de l"'équipe</param>
        /// <param name="hymne">Chemin d'accès à l'hymne de l'équipe</param>
        
        public Equipe(String nom, TypeEquipe type, String description, String cheminLogo, String hymne)
            :this(nom,type,description,cheminLogo)
        {           
           Hymne = hymne;
         }

        /// <summary>
        /// Constructeur sans le paramètre hymne
        /// </summary>
        /// <param name="nom">nom de l'équipe</param>
        /// <param name="type">type de l'équipe</param>
        /// <param name="description">Description de l'équipe</param>
        /// <param name="cheminLogo">Chemin d'accès au logo de l"'équipe</param>
        
        public Equipe(String nom, TypeEquipe type, String description, String cheminLogo)
        {
            Nom = nom;
            Type = type;
            Description = description;
            CheminLogo = cheminLogo;
                                 
        }

        /// <summary>
        /// ajoute un trophé à la liste de trophé
        /// </summary>
        /// <param name="t">trophé à ajouter.</param>
        public void ajouterPalmares(Trophes t)
        {
            Palmares.Add(t);
        }

        /// <summary>
        /// Ajoute un commentaire à la liste de commentaires
        /// </summary>
        /// <param name="c">commentaire à ajouter</param>
        public void ajouterCommentaire(Commentaire c)
        {
            Commentaires.Add(c);
        }

        
        /// <summary>
        ///Ajoute joueur à l'effectif
        /// </summary>
        /// <param name="j"> joueur à ajouter</param>
        public void ajouterJoueur(Joueur j)
        {
            Effectif.Add(j);
        }

        /// <summary>
        /// Supprime un joueur de l'effectif 
        /// </summary>
        /// <param name="j">joueur à supprimer</param>
        public void supprimerJoueur(Joueur j)
        {
            Effectif.Remove(j);
        }

        /// <summary>
        /// vérifie que "right" est une équipe
        /// </summary>
        /// <param name="right">objet comparer avec équipe</param>
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

            return this.Equals(right as Equipe);
        }

        /// <summary>
        /// retourne le hash code
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }

        /// <summary>
        /// méthode Equals de la classe Equipe
        /// </summary>
        /// <param name="equipe">équipe que l'on souhaite comparer</param>
        /// <returns>true or false</returns>
        public bool Equals(Equipe equipe)
        {
            if (this.Nom.Equals(equipe.Nom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// méthode ToString de la classe équipe
        /// </summary>
        /// <returns>retourne un string comprenant le nom de l'équipe, le type, la description ainsi que la liste des commentaires, des joueurs et des troophés.</returns>
        public override string ToString()
        {
            return"\n"+ Nom + " " + Utils.TypeEquipeToString[Type] + " " + Description;
        }

    }
}
