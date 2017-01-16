using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
    /// <summary>
    /// Cette contient tous les outils qui nous sont utiles.
    /// </summary>
    public static class  Utils
    {
        /// <summary>
        /// ce dictionnaire nous permet de transformer un grade en string. la clé est un grade et la valeur est le string correspondant.
        /// </summary>
        public static Dictionary<Grade, string> GradeToString = new Dictionary<Grade, string>()
        {
            { Grade.Cadet, "cadet" },
            { Grade.Junior, "junior" },
            { Grade.MiniPoussin, "mini-poussin" },
            { Grade.Poussin, "poussin" },
            { Grade.President, "président" },
            { Grade.Senior, "senior" }

        };

        /// <summary>
        /// ce dictionnaire nous permet de transformer un Poste en string. la clé est un Poste et la valeur est le string correspondant.
        /// </summary>
        public static Dictionary<Poste, string> PosteToString = new Dictionary<Poste, string>()
        {
            { Poste.pilier, "pilier" },
            { Poste.talonneur, "talonneur" },
            { Poste.deuxièmeLigne, "deuxième ligne" },
            { Poste.troisièmeLigneAile, "troisième ligne aile" },
            { Poste.troisièmeLigneCentre, "troisième ligne centre" },
            { Poste.demiDeMelee, "demi de mélée" },
            { Poste.demiOuverture, "demi d'ouverture" },
            { Poste.centre, "centre" },
            { Poste.ailier, "ailier" },
            { Poste.arriere, "arrière" }           

        };

        /// <summary>
        /// ce dictionnaire nous permet de transformer un type d'équipe en string. la clé est un type d'équipe et la valeur est le string correspondant.
        /// </summary>
        public static Dictionary<TypeEquipe, string> TypeEquipeToString = new Dictionary<TypeEquipe, string>()
        {
             { TypeEquipe.Club, "club" },
            { TypeEquipe.EquipeNational, "équipe nationale" }
        };

        /// <summary>
        /// Ce dictionnaire nous permet de transformer un sexe en string, la clé est le sexe et la valeur est le string
        /// </summary>
        public static Dictionary<Sexe, string> SexeToString = new Dictionary<Sexe, string>()
        {
            {Sexe.Femme, "femme" },
            {Sexe.Homme, "homme" }
        };



        public static Dictionary<string, Sexe> StringToSexe = new Dictionary<string, Sexe>()
        {
            {"femme", Sexe.Femme },
            {"homme", Sexe.Homme }
        };

        public static Dictionary<string, TypeEquipe> StringToTypeEquipe = new Dictionary<string, TypeEquipe>()
        {
            {"club", TypeEquipe.Club },
            {"équipe nationale", TypeEquipe.EquipeNational }
        };

        public static Dictionary<string, Grade> StringToGrade = new Dictionary<string, Grade>()
        {
            {"cadet", Grade.Cadet },
            {"junior", Grade.Junior},
            {"mini-poussin",Grade.MiniPoussin },
            {  "poussin",Grade.Poussin },
            { "président", Grade.President },
            {"senior", Grade.Senior }
        };

        public static Dictionary<string, Poste> StringToPoste = new Dictionary<string, Poste>()
        {
             {"pilier", Poste.pilier },
            { "talonneur" ,Poste.talonneur},
            { "deuxième ligne" , Poste.deuxièmeLigne},
            {"troisième ligne centre", Poste.troisièmeLigneCentre },
            {"demi de mélée", Poste.demiDeMelee },
            { "demi d'ouverture"  ,Poste.demiOuverture},
            {"centre", Poste.centre },
            { "ailier" , Poste.ailier},
            { "arrière", Poste.arriere }
        };


    }
}
