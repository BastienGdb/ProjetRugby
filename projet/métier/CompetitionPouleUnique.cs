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
    public class CompetitionPouleUnique : Competition
    {
        /// <summary>
        /// Dictionnaire qui a pour clé une équipes, un int en valeur et qui permet d'obtenir le classement 
        /// </summary>
        public Dictionary<Equipe, int> classement = new Dictionary<Equipe, int>();
        /// <summary>
        /// Permet orsqu'on l'appelle de choisir la bonne méthode pour attribuer les points en fonction de la compétition
        /// </summary>
        private FabriqueMajPoints fabrique = new FabriqueMajPoints();
        /// <summary>
        /// Liste des équipes de cette compétition
        /// </summary>
        [DataMember]
        public List<Equipe> Equipes { get; internal set; } = new List<Equipe>();
        /// <summary>
        /// Permet d'obtenir le classement de la compétition grâce à une requête LINQ qui tri le Dictionnaire classement en fonction des points des équipes
        /// </summary>
        public IEnumerable<EquipePoints> Points
        {
            get
            {
                return classement.Select(kvp => new EquipePoints { Equipe = kvp.Key, Points = kvp.Value }).OrderByDescending (e => e.Points);
            }
        }
      

        /// <summary>
        ///Constructeur de CompetitionPouleUnique
        /// </summary>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="nom"></param>
        public CompetitionPouleUnique( string description, TypeEquipe type, string nom, string chemin)
        {
            Description = description;
            TypeEquipeParticipante = type;
            Nom = nom;
            CheminLogo = chemin;
        }

        /// <summary>
        /// Methode permettant de récuperer sous forme d'une liste de matchs le calendrier d'une équipe
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public List<Match> getCalendrierEquipe(Equipe e)
        {
            var c = new List<Match>();
            foreach (Match m in Calendrier)
            {
                if (m.EquipeA.Equals(e))
                {
                    c.Add(m);
                }
                else if (m.EquipeB.Equals(e))
                {
                    c.Add(m);
                }
            }
            return c;
        }

        /// <summary>
        /// Methode permettant d'ajouter une Equipe à la compétition
        /// </summary>
        /// <param name="e"></param>
        public void AjouterEquipe (Equipe e)
        {
            foreach(var v in Equipes)
            {
                if (v.Equals(e))
                {
                    return;
                }
            }
            Equipes.Add(e);
            classement.Add(e, 0);
        }

        /// <summary>
        /// Permet d'ajouter des points à une équipe
        /// </summary>
        /// <param name="e">l'équipe à qui il faut rajouter des points</param>
        /// <param name="nbPoints">Le nombre de points à ajouter</param>
        public void AjouterPointEquipe(Equipe e, int nbPoints)
        {
            if (classement.ContainsKey(e))
            {
                classement[e] += nbPoints;
                
            }        
        }

        /// <summary>
        /// Ajouter un match sans le résultat
        /// </summary>
        /// <param name="equipeA">premiere équipe</param>
        /// <param name="equipeB">seconde équipe</param>
        /// <param name="journée">journée à laquelle à lieu le match</param>
        /// <param name="compet">compétition pour laquelle les équipes s'affrontent</param>
        public void AjouterUnMatch(Match m)
        {
            Calendrier.Add(m);
        }

        /// <summary>
        /// Cette méthode ajoute un résultat à un match.
        /// On utilise la classe FabriqueMajPoints qui nous retourne la méthode MajPoints qui correspond à la bonne méthode pour calculer
        /// les points gagnés au classement par l'équipe.
        /// </summary>
        /// <param name="m">match au quel on veut ajouter un résultat</param>
        /// <param name="resultat"> résultat que l'on veut ajouter</param>
        public void AjouterUnResultat(Match m, resultat resultat)
        {
                m.res.scoreEquipeA = resultat.scoreEquipeA;
                m.res.scoreEquipeB = resultat.scoreEquipeB;
                m.res.nbEssaiEquipeA = resultat.nbEssaiEquipeA;
                m.res.nbEssaiEquipeB = resultat.nbEssaiEquipeB;

               IMAJ_Points maj = fabrique.FabriqueMaj(this);
               m.Joue = true;
               maj.MajPoints(this, m);
            }
       /// <summary>
       /// Methode pour suprimmer une équipe
       /// </summary>
       /// <param name="e"></param>   
       override
        public void SupprimerEquipe(Equipe e)
        {
            Equipes.Remove(e);
        }

        /// <summary>
        /// Redéfinition de la méthode ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nom + " est une compétion à poule unique de type "+ Utils.TypeEquipeToString[TypeEquipeParticipante] ;
        }



    }
    
}
