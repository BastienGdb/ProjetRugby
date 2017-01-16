using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
    public class Utilisateur
    {
        public Utilisateur() { }
        /// <summary>
        /// Methode permettant à un uttilisateur non inscrit de s'inscrire
        /// </summary>
        /// <param name="mdp"></param>
        /// <param name="confirmationMdp"></param>
        /// <param name="sexe"></param>
        /// <param name="pseudo"></param>
        public void Inscription(string mdp, string confirmationMdp, Sexe sexe, string pseudo, Equipe equipeFavorite, Equipe equipeNationalFavorite)
        {
            new UtilisateurInscrit(mdp, pseudo, sexe, equipeFavorite, equipeNationalFavorite);
        }
    }
}
