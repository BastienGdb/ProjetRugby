using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace métier
{
    /// <summary>
    /// Enumération des différents sexes que peut avoir un utilisateur
    /// </summary>
    [DataContract]
    public enum Sexe
    {
        [EnumMember]
        Homme,
        [EnumMember]
        Femme
    }
}
