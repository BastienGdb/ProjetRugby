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
    public abstract class Competition
    {
        [DataMember]
        public string CheminLogo { get; set; }
        /// <summary>
        /// Description de la compétition
        /// </summary>
        [DataMember]
        public String Description { get;internal set; }
        /// <summary>
        /// Type des équipes participante à la compétition
        /// </summary>
        [DataMember]
        public TypeEquipe TypeEquipeParticipante { get; internal set; }
        /// <summary>
        /// Nom de la compétition
        /// </summary>
        [DataMember]
        public String Nom { get; internal set; }
        /// <summary>
        /// Liste des commmentaires laissé par les utilisateurs sur la compétition
        /// </summary>
        [DataMember]
        public List<Commentaire> Commentaires { get; internal set; } = new List<Commentaire>();
        /// <summary>
        /// Liste de match qui correspond au calendrier de la compétition
        /// </summary>
        public List<Match> Calendrier { get; internal set; } = new List<Match>();

        public abstract void SupprimerEquipe(Equipe e);
    }


}
