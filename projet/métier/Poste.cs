using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace métier
{
    /// <summary>
    /// Enumération des différents poste qu'un joueur peut avoir
    /// </summary>
    [DataContract]
    public enum Poste
    {
        [EnumMember]
        pilier,
        [EnumMember]
        talonneur,
        [EnumMember]
        deuxièmeLigne,
        [EnumMember]
        troisièmeLigneAile,
        [EnumMember]
        troisièmeLigneCentre,
        [EnumMember]
        demiDeMelee,
        [EnumMember]
        demiOuverture,
        [EnumMember]
        centre,
        [EnumMember]
        ailier,
        [EnumMember]
        arriere
    }

   

    
}
