using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace métier  
{
    /// <summary>
    /// Structure d'un résultat. Un résultat est composé du score des deux équipes ainsi que du nombre d'essai inscrit par chaque équipe.
    /// </summary>
    [DataContract]
    public struct resultat
    {
        /// <summary>
        /// Nombre de points inscrit par l'équipe A lors de ce match
        /// </summary>
        [DataMember]
        public int scoreEquipeA { get; set; }
        /// <summary>
        /// Nombre de point inscrit par l'équipe B lors de ce match
        /// </summary>
        [DataMember]
        public int scoreEquipeB { get; set; }
        /// <summary>
        /// Nombre d'essai inscrit par l'équipe A lors de ce match
        /// </summary>
        [DataMember]
        public int nbEssaiEquipeA { get; set; }
        /// <summary>
        /// Nombre d'essai inscrit par l'équipe B lors de ce match
        /// </summary>
        [DataMember]
        public int nbEssaiEquipeB { get; set; }

        /// <summary>
        /// constructeur d'un résultat
        /// </summary>
        /// <param name="equipeA">score 1ère équipe</param>
        /// <param name="equipeB">score 2ème équipe</param>
        /// <param name="essaiA"> nombre d'essai de la première équipe</param>
        /// <param name="essaiB">nombre d'essai de la seconde équipe</param>
        public resultat(int equipeA,int equipeB,int essaiA,int essaiB)
        {
            scoreEquipeA = equipeA;
            scoreEquipeB = equipeB;
            nbEssaiEquipeA = essaiA;
            nbEssaiEquipeB = essaiB;
        }
    }
    /// <summary>
    /// Classe match qui est composé de deux équipes d'une date, d'un résultat et d'une compétition.
    /// </summary>
    [DataContract]
    public class Match : IEquatable<Match>
    {
        /// <summary>
        /// Premiere equipe participant au match
        /// </summary>
        [DataMember]
        public Equipe EquipeA { get; private set; }
        /// <summary>
        /// Deuxième equipes participant au match
        /// </summary>
        [DataMember]
        public Equipe EquipeB { get; private set; }
        /// <summary>
        /// Journée pour laquelle ce match se joues
        /// </summary>
        [DataMember]
        public int Journée { get; private set; }
        /// <summary>
        /// Résultat de ce match( initialisé à 0)
        /// </summary>
        [DataMember]
        public resultat res;

        /// <summary>
        /// Compétition pour laquelle ce match est joué
        /// </summary>
        [DataMember]
        public Competition Competition { get; set; }
        /// <summary>
        /// Booléen permettant de savoir si ce match a été joué ou non
        /// </summary>
        [DataMember]
        public bool Joue { get; set; }
        public int ScoreA { get; private set; }
        public int ScoreB { get; private set; }

        /// <summary>
        /// Constructeur d'un match sans renseigner le résultat
        /// </summary>
        /// <param name="equipeA">équipe A</param>
        /// <param name="equipeB"> équipe B</param>
        /// <param name="journée">journée du match</param>
        /// <param name="compet">compétition</param>
        public Match (Equipe equipeA,Equipe equipeB, int journée, Competition compet)
        {
            EquipeA = equipeA;
            EquipeB = equipeB;
            Journée = journée;
            Competition = compet;
            Joue = false;
            res = new resultat(0, 0, 0, 0);
            
        }
        /// <summary>
        /// Constructeur de match avec résultat
        /// </summary>
        /// <param name="equipeA"></param>
        /// <param name="equipeB"></param>
        /// <param name="journée"></param>
        /// <param name="compet"></param>
        /// <param name="r"></param>
        public Match(Equipe equipeA, Equipe equipeB, int journée, Competition compet, int scoreA,int scoreB,int essaiA,int essaiB)
        {
            EquipeA = equipeA;
            EquipeB = equipeB;
            Journée = journée;
            Competition = compet;
            res = new resultat(scoreA, scoreB, essaiA, essaiB);
            ScoreA = scoreA;
            ScoreB = scoreB;
            Joue = true;
        }


        /// <summary>
        /// méthode Equals de la classe match
        /// </summary>
        /// <param name="m">match à comparer</param>
        /// <returns></returns>
        public bool Equals(Match m)
        {
            if(this.Journée == m.Journée && this.EquipeA.Equals(m.EquipeA) && this.EquipeB.Equals(m.EquipeB))
            {
                return true;
            }else
            {
                return false;
            }
        }

        /// <summary>
        /// vérifie que "right" est un match
        /// </summary>
        /// <param name="right">objet comparer avec match</param>
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

            return this.Equals(right as Match);
        }

        /// <summary>
        /// retourne le hash code
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return Journée.GetHashCode() + EquipeA.GetHashCode() + EquipeB.GetHashCode();
        }

        /// <summary>
        /// Redéfinition de la méthode ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Joue == true)
            {
                return "Match " + EquipeA.Nom + " " + res.scoreEquipeA + "-" + res.scoreEquipeB + " " + EquipeB.Nom + " comptant pour la journée " + Journée;

            }
            else
            {
                return "Match " + EquipeA.Nom + " " + "-" + " " + EquipeB.Nom + " comptant pour la journée" + Journée +" n'a pas encore été joué";

            }
        }


    }
}
