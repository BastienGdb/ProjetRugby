using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
    [DataContract]
    public class CompetitionAPoule: Competition
    {


        /// <summary>
        /// Liste de CompetitionPouleUnique qui correspond aux differentes poules de cette compétition
        /// </summary>
        [DataMember]
        public List<CompetitionPouleUnique> Poules { get; set; } = new List<CompetitionPouleUnique>();

        /// <summary>
        ///Constructeur de CompetitionAPoule
        /// </summary>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="nom"></param>
        public CompetitionAPoule(string description, TypeEquipe type, string nom,string chemin)
        {
            Description = description;
            TypeEquipeParticipante = type;
            Nom = nom;
            CheminLogo = chemin;
        }

        /// <summary>
        /// Methode Pour ajouter une Poule à une Competition à poules
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="c"></param>
        public void AjouterUnePoules(string nom, CompetitionPouleUnique c)
        {
            Poules.Add(new CompetitionPouleUnique("Poules de la compet", c.TypeEquipeParticipante, nom,c.CheminLogo));
        }


        /// <summary>
        /// Methode permettant de récupérer la liste des équipes d'une poule.
        /// </summary>
        public List<Equipe> getListeEquipeDeLaPoule(string nom)
        {
            var p = new List<Equipe>();

            foreach(CompetitionPouleUnique c in Poules)
            {
                if (nom.Equals(c.Nom))
                {
                    return c.Equipes;
                }
            }
            return null;
        }
        /// <summary>
        /// Methode permettant d'ajouter une équipe à une poule
        /// </summary>
        /// <param name="e"></param>
        /// <param name="nom"></param>
        public void AjouterEquipe(Equipe e, string nom)
        {
            foreach(CompetitionPouleUnique c in Poules)
            {
                if (c.Nom.Equals(nom))
                {
                    c.AjouterEquipe(e);
                }
            }
        }  
        /// <summary>
        /// Methode permettant de supprmier un eéquipe d'une poule
        /// </summary>
        /// <param name="e"></param>
        /// <param name="nom"></param>
        /// 
        override
        public void SupprimerEquipe(Equipe e)
        {
            foreach(CompetitionPouleUnique c in Poules)
            {
                if (c.Equipes.Contains(e))
                {
                    c.SupprimerEquipe(e);
                }
            }
        }

        /// <summary>
        /// Redéfinition de la méthode ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Nom + " est une compétion à poules de type " + this.TypeEquipeParticipante.ToString();
        }


    }
}
