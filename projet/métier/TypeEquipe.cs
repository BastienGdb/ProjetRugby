using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace métier
{
    /// <summary>
    /// Enumération des différents type possible d'une équipe (club ou équipe nationale)
    /// </summary>
    [DataContract]
    public enum TypeEquipe
    {
        [EnumMember]
        EquipeNational,
        [EnumMember]
        Club
    }
}
