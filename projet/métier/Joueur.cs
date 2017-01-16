using métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace métier
{
    [DataContract]
    public class Joueur :IEquatable<Joueur>
    {

        /// <summary>
        /// Nom du joueur
        /// </summary>
        [DataMember]
        public string Nom { get; private set; }
        /// <summary>
        /// Prenom du joueur
        /// </summary>
        [DataMember]
        public string Prenom { get;private set; }
        /// <summary>
        /// Poid du joueru
        /// </summary>
        [DataMember]
        public float Poids { get; private set; }
        /// <summary>
        /// Taille du joueur
        /// </summary>
        [DataMember]
        public float Taille { get; private set; }
        /// <summary>
        /// Nationalité du joueur
        /// </summary>
        [DataMember]
        public string Nationalite { get; private set; }
        /// <summary>
        /// Nombre de séléction du joueur pour son équipes nationale
        /// </summary>
        [DataMember]
        public int Selection { get; set; }
        /// <summary>
        /// Equipe pour laquelle le joueur évolue actuellement
        /// </summary>
        [DataMember]
        public Equipe EquipeActuelle { get; set; }
        /// <summary>
        /// Chemin vers la photo du joueur
        /// </summary>
        [DataMember]
        public string Photo { get; private set; }
        /// <summary>
        /// Poste auquel joue le joueur
        /// </summary>
        [DataMember]
        public Poste PosteJoueur { get; private set; }

        /// <summary>
        /// Liste des commentaires laissés par les utilisateurs pour ce joueur
        /// </summary>
        internal List<Commentaire> Commentaires { get; set; } = new List<Commentaire>();
        /// <summary>
        /// Liste des trophés remporté par ce joueur
        /// </summary>
        internal List<Trophes> Palmares { get; set; } = new List<Trophes>();
        /// <summary>
        /// Constructeur avec tous les paramètres
        /// </summary>
        /// <param name="nom">nom du joueur</param>
        /// <param name="prenom">prénom du joueur</param>
        /// <param name="poids">poids du joueur</param>
        /// <param name="taille">taille du joueur</param>
        /// <param name="nationnalite">nationnalité du joueur</param>
        /// <param name="selection">nombre de selection du joueur</param>
        /// <param name="equipeActuelle">equipe actuelle du joueur</param>
        /// <param name="photo">chemin d'accès à la photo du joueur</param>
        /// <param name="poste">poste du joueur</param>
        public Joueur(String nom, String prenom, float poids, float taille, String nationnalite, int selection, Equipe equipeActuelle, String photo, Poste poste)
            : this(nom,prenom,poids,taille,nationnalite,selection,equipeActuelle,poste)
        {
            Photo = photo;
                                  
        }

        /// <summary>
        /// Constructeur d'un joueur avec poids et taille
        /// </summary>
        /// <param name="nom">nom du joueur</param>
        /// <param name="prenom">prénom du joueur</param>
        /// <param name="poids">poids du joueur</param>
        /// <param name="taille">taille du joueur</param>
        /// <param name="nationnalite">nationnalité du joueur</param>
        /// <param name="selection">nombre de selection du joueur</param>
        /// <param name="equipeActuelle">equipe actuelle du joueur</param>
        /// <param name="poste">poste du joueur</param>
        public Joueur(String nom, String prenom, float poids, float taille, String nationnalite, int selection, Equipe equipeActuelle,Poste poste)
            : this(nom, prenom, nationnalite, selection, equipeActuelle, poste)
        {           
            Poids = poids;
            Taille = taille;
            
         }



        /// <summary>
        /// constructueur d'un joueur avec photo
        /// </summary>
        ///  <param name="nom">nom du joueur</param>
        /// <param name="prenom">prénom du joueur</param>
        /// <param name="nationnalite">nationnalité du joueur</param>
        /// <param name="selection">nombre de selection du joueur</param>
        /// <param name="equipeActuelle">equipe actuelle du joueur</param>
        /// <param name="photo">chemin d'accès à la photo du joueur</param>
        /// <param name="poste">poste du joueur</param>
        public Joueur(String nom, String prenom, String nationnalite, int selection, Equipe equipeActuelle, String photo, Poste poste)
            :this(nom,prenom,nationnalite, selection,equipeActuelle,poste)
        {
            Photo = photo;
        }

        /// <summary>
        /// Constructeur avec les attributs qui doivent être obligatoirement renseignés.
        /// </summary>
        ///  <param name="nom">nom du joueur</param>
        /// <param name="prenom">prénom du joueur</param>
        /// <param name="nationnalite">nationnalité du joueur</param>
        /// <param name="selection">nombre de selection du joueur</param>
        /// <param name="equipeActuelle">equipe actuelle du joueur</param>
        /// <param name="poste">poste du joueur</param>
        public Joueur(String nom, String prenom, String nationnalite, int selection, Equipe equipeActuelle, Poste poste)
        {
            Nom = nom;
            Prenom = prenom;
            Nationalite = nationnalite;
            Selection = selection;
            EquipeActuelle = equipeActuelle;
            PosteJoueur = poste;
            

        }


       
        /// <summary>
        /// vérifie que "right" est un joueur
        /// </summary>
        /// <param name="right">objet comparer avec Joueur</param>
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

            return this.Equals(right as Joueur);
        }

        /// <summary>
        /// retourne le hash code
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return Nom.GetHashCode() + Prenom.GetHashCode();
        }

        /// <summary>
        /// Methode permettant de comparer deux joueurs
        /// </summary>
        /// <param name="j">joueur que l'on veut comparer</param>
        /// <returns>vrai ou faux</returns>
        public bool Equals(Joueur j)
        {
            if (this.Nom.Equals(j.Nom) && this.Prenom.Equals(j.Prenom) && this.PosteJoueur.Equals(j.PosteJoueur) && this.Nationalite.Equals(j.Nationalite))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// permet d'ajouter un commentaire à la liste des commentaires
        /// </summary>
        /// <param name="c"> commentaire à ajouter à la liste</param>
        public void ajouterCommentaire(Commentaire c)
        {
            Commentaires.Add(c);
        }

        /// <summary>
        /// permet d'ajouter un trophé à la liste des trophé
        /// </summary>
        /// <param name="t"> trophé à ajouter à la liste</param>
        public void ajouterTrophe(Trophes t)
        {
            Palmares.Add(t);
        }

        /// <summary>
        /// méthode toString de joueur
        /// </summary>
        /// <returns>retourne un string comprenant le nom, le prénom, la nationnalité, l'équipe actuelle et le poste.</returns>
        public override string ToString()
        {
            return "\n"+ Nom +" "+ Prenom +" "+Nationalite+ " " + EquipeActuelle.Nom + " "+ Utils.PosteToString[PosteJoueur];
        }
    }
}
