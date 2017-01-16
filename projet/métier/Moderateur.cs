using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
    public class Moderateur :UtilisateurInscrit
    {
        /// <summary>
        /// Constructeur de Moderateur avec photo
        /// </summary>
        /// <param name="motDePasse"></param>
        /// <param name="pseudo"></param>
        /// <param name="sexe"></param>
        /// <param name="photo"></param>
        /// <param name="equipeFavorite"></param>
        /// <param name="equipeNationalFavorite"></param>
        public Moderateur (string motDePasse, string pseudo, Sexe sexe, string photo, Equipe equipeFavorite, Equipe equipeNationalFavorite) 
            : base(motDePasse, pseudo, sexe,photo, equipeFavorite, equipeNationalFavorite)
        {}
        /// <summary>
        /// Constructeur de Moderateur sans photo
        /// </summary>
        /// <param name="motDePasse"></param>
        /// <param name="pseudo"></param>
        /// <param name="sexe"></param>
        /// <param name="equipeFavorite"></param>
        /// <param name="equipeNationalFavorite"></param>
        public Moderateur (string motDePasse, string pseudo, Sexe sexe, Equipe equipeFavorite, Equipe equipeNationalFavorite)
            : base(motDePasse, pseudo, sexe, equipeFavorite, equipeNationalFavorite)
        {}
        /// <summary>
        /// Constructeur de Moderateur avec juste mot de passe et pseudo
        /// </summary>
        /// <param name="motDePasse"></param>
        /// <param name="pseudo"></param>
        public Moderateur(string motDePasse, string pseudo):base(motDePasse,pseudo)
        { }



    }
}
