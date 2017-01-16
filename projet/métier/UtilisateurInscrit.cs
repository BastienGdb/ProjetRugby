
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace métier
{
    [DataContract]
     public class UtilisateurInscrit : Utilisateur
    {
        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>
        [DataMember]
        public string MotDePasse { get; internal set; }
        /// <summary>
        /// Equipe de type club favorite de l'utilisateur
        /// </summary>
        [DataMember]
        public Equipe EquipeFavorite { get; internal set; }
        /// <summary>
        /// Equipe de type equipe nationale favorite de l'utilisateur
        /// </summary>
        [DataMember]
        public Equipe EquipeNationalFavorite { get; internal set; }
        /// <summary>
        /// Chemin vers la photo choisi par l'utilisateur
        /// </summary>
        [DataMember]
        public String Photo { get; internal set; }
        /// <summary>
        /// Booléen permttant de savoir si l'utilisateur est connecté ou non 
        /// </summary>
        [DataMember]
        public bool Connecte { get; set; }
        /// <summary>
        /// Pseudo de l'utilisateur
        /// </summary>
        [DataMember]
        public String Pseudo { get; internal set; }
        /// <summary>
        /// Sexe de l'utilisateur
        /// </summary>
        [DataMember]
        public Sexe Sexe { get; internal set; }
        /// <summary>
        /// Grade de l'utilisateur
        /// </summary>
        [DataMember]
        public Grade Grade { get; set; }
        /// <summary>
        /// Nombre de commentaire et de j'aime éffectué par l'utilisateur
        /// </summary>
        [DataMember]
        public int NbCommEtJaime { get; set; }


        /// <summary>
        /// Constructeur d'utilisateur inscrit avec juste un mot de pass eet un pseudo
        /// </summary>
        /// <param name="motDePasse"></param>
        /// <param name="pseudo"></param>
        public UtilisateurInscrit(string motDePasse, string pseudo)
        {
            Pseudo = pseudo;
            MotDePasse = motDePasse;
        }

        /// <summary>
        /// Constructeur avec tous les paramètres possibles
        /// </summary>
        /// <param name="motDePasse"></param>
        /// <param name="pseudo"></param>
        /// <param name="sexe"></param>
        /// <param name="photo"></param>
        /// <param name="equipeFavorite"></param>
        /// <param name="equipeNationalFavorite"></param>
        public UtilisateurInscrit(string motDePasse, string pseudo, Sexe sexe, string photo, Equipe equipeFavorite, Equipe equipeNationalFavorite) : this(motDePasse, pseudo, sexe, equipeFavorite, equipeNationalFavorite)
        {
            Photo = photo;
        }
        /// <summary>
        /// Constructeur sans photo mais equipes favorite
        /// </summary>
        /// <param name="motDePasse"></param>
        /// <param name="pseudo"></param>
        /// <param name="sexe"></param>
        /// <param name="equipeFavorite"></param>
        /// <param name="equipeNationalFavorite"></param>
        public UtilisateurInscrit(string motDePasse, string pseudo, Sexe sexe, Equipe equipeFavorite, Equipe equipeNationalFavorite)
        { 
            MotDePasse = motDePasse;
            Pseudo = pseudo;
            Sexe = sexe;
            EquipeFavorite = equipeFavorite;
            EquipeNationalFavorite = equipeNationalFavorite;

        }



        /// <summary>
        /// Modifie le grade en fonction du nombre de j'aime et de commentaire de l'utilisateur.
        /// Cette méthode est appelée lorsque l'on rajoute un commentaire ou un j'aime.
        /// </summary>
        public void modifierGrade()
        {
            int score = NbCommEtJaime;

            if (score > 10)
            {
                Grade = Grade.MiniPoussin;
            }
            if (score > 30)
            {
                Grade = Grade.Poussin;
            }
            if (score > 50)
            {
                Grade = Grade.Cadet;
            }
            if (score > 70)
            {
                Grade = Grade.Junior;
            }
            if (score > 90)
            {
                Grade = Grade.Senior;
            }
            if (score > 110)
            {
                Grade = Grade.President;
            }
           
        }
        /// <summary>
        /// Methode permettant la déconnexion d'un utilisateur
        /// </summary>
        public void Deconnexion()
        {
            Connecte = false;
        }
      
    }
}
