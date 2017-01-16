
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
    class UtilisateurConnecte
    {
        public String Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        private String nom;

        public String Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }
        private String prenom;

        public String MotDePasse
        {
            get
            {
                return motDePasse;
            }
            set
            {
                motDePasse = value;
            }
        }
        private String motDePasse;

        public Equipe EquipeFavorite
        {
            get
            {
                return equipeFavorite;
            }
            set
            {
                equipeFavorite = value;
            }
        }
        private Equipe equipeFavorite;

        public Equipe EquipeNationalFavorite
        {
            get
            {
                return equipeNationalFavorite;
            }
            set
            {
                equipeNationalFavorite = value;
            }
        }
        private Equipe equipeNationalFavorite;

        public String Photo
        {
            get
            {
                return photo;
            }
            set
            {
                photo = value;
            }
        }
        private String photo;

        public bool Connecte
        {
            get
            {
                return connecte;
            }
            set
            {
                connecte = value;
            }
        }
        private bool connecte;

        public int NbCommentaire
        {
            get
            {
                return nbCommentaire ;
            }
            set
            {
                nbCommentaire = value;
            }
        }
        private int nbCommentaire;

         public String Pseudo
        {
            get
            {
                return pseudo;
            }
            set
            {
                pseudo = value;
            }
        }
        private String pseudo;

        public Sexe Sexe
        {
            get
            {
                return sexe;
            }
            set
            {
                sexe = value;
            }
        }
        private Sexe sexe;

        public Grade Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }
        private Grade grade;

        public int NbJaime
        {
            get
            {
                return nbJaime;
            }
            set
            {
                nbJaime = value;
            }
        }
        private int nbJaime;

    
        /// <summary>
        /// Modifie le mot de passe de l'utilisateur
        /// Cette méthode comprend un test de vérification de l'ancien mot de passe.
        /// </summary>
        /// <param name="newMdp"> nouveau mot de passe </param>
        /// <param name="mdp"> ancien mot de passe</param>
         public void modifierMotDePasse(String newMdp,String mdp)
        {
            if (this.motDePasse.Equals(mdp))
            {
                MotDePasse = newMdp;
            }

        }



        public void modifierNom(String newNom)
        {
            Nom = newNom;
        }

        public void modifierPrenom(String newPrenom)
        {
            Prenom = newPrenom;
        }

        public void modifierEquipeFavorite(Equipe newEquipe)
        {
            EquipeFavorite = newEquipe;
        }

        public void modifierEquipeNationnaleFavorite(Equipe newEquipe)
        {
            EquipeNationalFavorite = newEquipe;
        }

        public void modifierPhoto(String newPhoto)
        {
            Photo = newPhoto;
        }

        /// <summary>
        /// Modifie le grade en fonction du nombre de j'aime et de commentaire de l'utilisateur.
        /// </summary>
        public void modifierGrade()
        {
            int score = NbCommentaire + NbJaime;

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



    }
}
