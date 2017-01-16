using métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistance
{
    public class StubDataManager : IDataManager
    {

        private List<UtilisateurInscrit> listeUser = new List<UtilisateurInscrit>()
        {

            new UtilisateurInscrit("1105","antho",Sexe.Homme,new Equipe("Clermont-Ferrand",TypeEquipe.Club,"Association sportive Montferrandaise","/Images/logotop14/ASM.png"), new Equipe("France",TypeEquipe.EquipeNational,"Equipe de France de Rugby","/Images/France.png")),
        };
        /// <summary>
        /// Chargement des Compétitions
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Competition> ChargeCompetition()
        {
            return new List<Competition>
            {
                new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "Top14","Images/Top14.png"),
                new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "ProD2","Images/ProD2.png"),
                new CompetitionAPoule("Championnat Européen", TypeEquipe.Club, "Champions Cup","Images/Hcup.png"),
                new CompetitionAPoule("Championnat Européen", TypeEquipe.Club, "Challenge Cup","Images/CC.png"),
                new CompetitionPouleUnique("tournoi des 6 nations", TypeEquipe.Club, "6 Nations","Images/6nations.png"),
                new CompetitionPouleUnique("Rugby Championship", TypeEquipe.Club, "4 Nations","Images/4nations.png"),
                new CompetitionAPoule("Coupe du monde", TypeEquipe.Club, "Coupe du monde","Images/CoupeDuMonde.png"),

            };
        }

        /// <summary>
        /// Chargement des équipes du top14
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Equipe> ChargeTop14()
        {
            return new List<Equipe>
            {
                new Equipe("Agen",TypeEquipe.Club,"Club de rugby de la ville d'Agen","/Images/logotop14/agen.png"),
                new Equipe("Bordeaux-Bègles",TypeEquipe.Club,"Union Bordeaux-Bègles","/Images/logotop14/bordeaux.png"),
                new Equipe("Brive",TypeEquipe.Club,"club de la ville de Brive","/Images/logotop14/brive.png"),
                new Equipe("Castres",TypeEquipe.Club,"Castres Olympique","/Images/logotop14/castres.png"),
                new Equipe("Clermont-Ferrand",TypeEquipe.Club,"Association sportive Montferrandaise","/Images/logotop14/ASM.png"),
                new Equipe("Grenoble",TypeEquipe.Club,"Club de rugby de la ville de Grenoble","/Images/logotop14/grenoble.png"),
                new Equipe("La Rochelle",TypeEquipe.Club,"Club de rugby de la ville de La Rochelle","/Images/logotop14/laRochelle.png"),
                new Equipe("Montpellier",TypeEquipe.Club,"Montpellier Hérault Rugby","/Images/logotop14/montpellier.png"),
                new Equipe("Oyonnax",TypeEquipe.Club,"Union sportive d'Oyonnax","/Images/logotop14/oyonnax.png"),
                new Equipe("Pau",TypeEquipe.Club,"Section Paloise","/Images/logotop14/Pau.png"),
                new Equipe("Racing 92",TypeEquipe.Club,"Le racing 92 est un club de la capitale","/Images/logotop14/racing.png"),
                new Equipe("Stade-Français",TypeEquipe.Club,"Stade-Français Paris","/Images/logotop14/StadeFrançais.png"),
                new Equipe("Toulon",TypeEquipe.Club,"Racing Club Toulonnais","/Images/logotop14/Toulon.png"),
                new Equipe("Toulouse",TypeEquipe.Club,"Stade Toulousain","/Images/logotop14/Toulouse.png"),

            };
        }

        public IEnumerable<Trophes> ChargePalmares()
        {
            return new List<Trophes>
            {
                new Trophes(new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "Top14","Images/Top14.png"),
                2010,"Bouclier de Brennus",
                new Equipe("Clermont-Ferrand",TypeEquipe.Club,"Association sportive Montferrandaise","/Images/logotop14/ASM.png")),

                new Trophes(new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "Top14","Images/Top14.png"),
                2011,"Bouclier de Brennus",
                new Equipe("Toulouse",TypeEquipe.Club,"Stade Toulousain","/Images/logotop14/Toulouse.png")),

                new Trophes(new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "Top14","Images/Top14.png"),
                2012,"Bouclier de Brennus",
                new Equipe("Toulouse",TypeEquipe.Club,"Stade Toulousain","/Images/logotop14/Toulouse.png")),

                new Trophes(new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "Top14","Images/Top14.png"),
                2013,"Bouclier de Brennus",
                new Equipe("Castres",TypeEquipe.Club,"Castres Olympique","/Images/logotop14/castres.png")),

                new Trophes(new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "Top14","Images/Top14.png"),
                2013,"Bouclier de Brennus",
                new Equipe("Castres",TypeEquipe.Club,"Castres Olympique","/Images/logotop14/castres.png")),

                new Trophes(new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "Top14","Images/Top14.png"),
                2014,"Bouclier de Brennus",
                new Equipe("Toulon",TypeEquipe.Club,"Racing Club Toulonnais","/Images/logotop14/Toulon.png")),

                new Trophes(new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "Top14","Images/Top14.png"),
                2015,"Bouclier de Brennus",
                new Equipe("Stade-Français",TypeEquipe.Club,"Stade-Français Paris","/Images/logotop14/StadeFrançais.png")),
               
                new Trophes( new CompetitionAPoule("Championnat Européen", TypeEquipe.Club, "Champions Cup","Images/Hcup.png"),
                2015,"Coupe d'Europe",
                new Equipe("Toulon",TypeEquipe.Club,"Racing Club Toulonnais","/Images/logotop14/Toulon.png")),

                new Trophes( new CompetitionAPoule("Coupe du monde", TypeEquipe.Club, "Coupe du monde","Images/CoupeDuMonde.png"),
                2015,"Coupe du Monde",
                new Equipe("Nouvelle-Zélande",TypeEquipe.EquipeNational,"All Blacks","/Images/AllBlacks.png")),

            };
        }

        public IEnumerable<Match> ChargeMatchs()
        {
            return new List<Match>
            {
                ///Match ProD2
                new Match (new Equipe("Aurillac",TypeEquipe.Club,"Club de rugby de la ville d'Albi","/Images/logoprod2/aurillac.png"),
                new Equipe("Tarbes",TypeEquipe.Club,"Club de rugby de la ville de Tarbes","/Images/logoprod2/tarbes.png"),1,
                new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "ProD2","Images/ProD2.png")),

                new Match (new Equipe("Bayonne",TypeEquipe.Club,"Club de rugby de la ville de Bayonne","/Images/logoprod2/bayonne.png"),
                new Equipe("Aurillac",TypeEquipe.Club,"Club de rugby de la ville d'Albi","/Images/logoprod2/aurillac.png"),2,
                new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "ProD2","Images/ProD2.png")),

                new Match(new Equipe("Aix en Provence",TypeEquipe.Club,"Club de rugby de la ville de Aix","/Images/logoprod2/aix.png"),
                new Equipe("Albi",TypeEquipe.Club,"Club de rugby de la ville d'Albi","/Images/logoprod2/albi.png"),1,
                new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "ProD2","Images/ProD2.png"),15,3,2,0),

                new Match (new Equipe("Albi",TypeEquipe.Club,"Club de rugby de la ville d'Albi","/Images/logoprod2/albi.png"),
                new Equipe("Aurillac",TypeEquipe.Club,"Club de rugby de la ville d'Albi","/Images/logoprod2/aurillac.png"),2,
                new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "ProD2","Images/ProD2.png"),20,25,1,5),

                // match top14

                new Match(new Equipe("La Rochelle",TypeEquipe.Club,"Club de rugby de la ville de La Rochelle","/Images/logotop14/laRochelle.png"),
                new Equipe("Clermont-Ferrand",TypeEquipe.Club,"Association sportive Montferrandaise","/Images/logotop14/ASM.png"),1,
                new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "Top14","Images/Top14.png"),6,44,0,5),

                new Match(new Equipe("Clermont-Ferrand",TypeEquipe.Club,"Association sportive Montferrandaise","/Images/logotop14/ASM.png"),
                new Equipe("Montpellier",TypeEquipe.Club,"Montpellier Hérault Rugby","/Images/logotop14/montpellier.png"),2,
                new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "Top14","Images/Top14.png"),22,21,3,2),


                new Match(new Equipe("Clermont-Ferrand",TypeEquipe.Club,"Association sportive Montferrandaise","/Images/logotop14/ASM.png"),
                new Equipe("Grenoble",TypeEquipe.Club,"Club de rugby de la ville de Grenoble","/Images/logotop14/grenoble.png"),26,
                new CompetitionPouleUnique("Championnat français", TypeEquipe.Club, "Top14","Images/Top14.png"),52,8,9,2),
            };
        }

        /// <summary>
        /// Chargement des équipes de proD2
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Equipe> ChargeProD2()
        {
            return new List<Equipe>
            {
                new Equipe("Aix en Provence",TypeEquipe.Club,"Club de rugby de la ville de Aix","/Images/logoprod2/aix.png"),
                new Equipe("Albi",TypeEquipe.Club,"Club de rugby de la ville d'Albi","/Images/logoprod2/albi.png"),
                new Equipe("Aurillac",TypeEquipe.Club,"Club de rugby de la ville d'Aurillac","/Images/logoprod2/aurillac.png"),
                new Equipe("Bayonne",TypeEquipe.Club,"Club de rugby de la ville de Bayonne","/Images/logoprod2/bayonne.png"),
                new Equipe("Béziers",TypeEquipe.Club,"Club de rugby de la ville de béziers","/Images/logoprod2/béziers.png"),
                new Equipe("Biarritz",TypeEquipe.Club,"Club de rugby de la ville de Biarritz","/Images/logoprod2/biarritz.png"),
                new Equipe("Bourgoin",TypeEquipe.Club,"Club de rugby de la ville de Bourgoin","/Images/logoprod2/bourgoin.png"),
                new Equipe("Carcassonne",TypeEquipe.Club,"Club de rugby de la ville de Carcassonne","/Images/logoprod2/carcassone.png"),
                new Equipe("Colomiers",TypeEquipe.Club,"Club de rugby de la ville de Colomiers","/Images/logoprod2/colomiers.png"),
                new Equipe("Dax",TypeEquipe.Club,"Club de rugby de la ville de Dax","/Images/logoprod2/dax.png"),
                new Equipe("Lyon",TypeEquipe.Club,"Club de rugby de la ville de Lyon","/Images/logoprod2/lyon.png"),
                new Equipe("Mont de Marsan",TypeEquipe.Club,"Club de rugby de la ville de Mont de Marsan","/Images/logoprod2/montDeMarsan.png"),
                new Equipe("Montauban",TypeEquipe.Club,"Club de rugby de la ville de Montauban","/Images/logoprod2/montauban.png"),
                new Equipe("Narbonne",TypeEquipe.Club,"Club de rugby de la ville de Narbonne","/Images/logoprod2/narbonne.png"),
                new Equipe("Perpignan",TypeEquipe.Club,"Club de rugby de la ville de Perpignan","/Images/logoprod2/perpignan.png"),
                new Equipe("Tarbes",TypeEquipe.Club,"Club de rugby de la ville de Tarbes","/Images/logoprod2/tarbes.png"),

            };
        }



        public IEnumerable<CompetitionPouleUnique> ChargeChampionsCup()
        {
            return new List<CompetitionPouleUnique>
            {
                new CompetitionPouleUnique("poule 1 de la champions Cup", TypeEquipe.Club,"Poule 1 Champions Cup","/Images/Hcup.png"),
                new CompetitionPouleUnique("poule 2 de la champions Cup", TypeEquipe.Club,"Poule 2 Champions Cup","/Images/Hcup.png"),
                new CompetitionPouleUnique("poule 3 de la champions Cup", TypeEquipe.Club,"Poule 3 Champions Cup","/Images/Hcup.png"),
                new CompetitionPouleUnique("poule 4 de la champions Cup", TypeEquipe.Club,"Poule 4 Champions Cup","/Images/Hcup.png"),
                new CompetitionPouleUnique("poule 5 de la champions Cup", TypeEquipe.Club,"Poule 5 Champions Cup","/Images/Hcup.png"),
            };
        }

        public IEnumerable<CompetitionPouleUnique> ChargeChallengeCup()
        {
            return new List<CompetitionPouleUnique>
            {
                new CompetitionPouleUnique("poule 1 de la challenge Cup", TypeEquipe.Club,"Poule 1 Challenge Cup","/Images/CC.png"),
                new CompetitionPouleUnique("poule 2 de la challenge Cup", TypeEquipe.Club,"Poule 2 Challenge Cup","/Images/CC.png"),
                new CompetitionPouleUnique("poule 3 de la challenge Cup", TypeEquipe.Club,"Poule 3 Challenge Cup","/Images/CC.png"),
                new CompetitionPouleUnique("poule 4 de la challenge Cup", TypeEquipe.Club,"Poule 4 Challenge Cup","/Images/CC.png"),
                new CompetitionPouleUnique("poule 5 de la challenge Cup", TypeEquipe.Club,"Poule 5 Challenge Cup","/Images/CC.png"),
            };
        }


        public IEnumerable<CompetitionPouleUnique> ChargeWordCup()
        {
            return new List<CompetitionPouleUnique>
            {
                new CompetitionPouleUnique("poule 1 de la coupe du monde", TypeEquipe.Club,"Poule 1 Coupe Du Monde","/Images/CoupeDuMonde.png"),
                new CompetitionPouleUnique("poule 2 de la coupe du monde", TypeEquipe.Club,"Poule 2 Coupe Du Monde","/Images/CoupeDuMonde.png"),
                new CompetitionPouleUnique("poule 3 de la coupe du monde", TypeEquipe.Club,"Poule 3 Coupe Du Monde","/Images/CoupeDuMonde.png"),
                new CompetitionPouleUnique("poule 4 de la coupe du monde", TypeEquipe.Club,"Poule 4 Coupe Du Monde","/Images/CoupeDuMonde.png"),
            };
        }

        public IEnumerable<Equipe> ChargePoule1ChampionsCup()
        {
            return new List<Equipe>
            {
                new Equipe("Saracens",TypeEquipe.Club,"Club anglais","/Images/logoChampionsCup/Saracens.png"),
                new Equipe("Ulster",TypeEquipe.Club,"Club anglais","/Images/logoChampionsCup/Ulster.png"),
                new Equipe("Oyonnax",TypeEquipe.Club,"Union sportive d'Oyonnax","/Images/logotop14/Oyonnax.png"),
                new Equipe("Toulouse",TypeEquipe.Club,"Stade Toulousain","/Images/logotop14/Toulouse.png"),
            };

        }

        public IEnumerable<Equipe> ChargePoule2ChampionsCup()
        {
            return new List<Equipe>
            {
                new Equipe("Exeter",TypeEquipe.Club,"Club anglais","/Images/logoChampionsCup/Exeter.png"),
                new Equipe("Ospreys",TypeEquipe.Club,"Club anglais","/Images/logoChampionsCup/Ospreys.png"),
                new Equipe("Clermont-Ferrand",TypeEquipe.Club,"Association sportive Montferrandaise","/Images/logotop14/ASM.png"),
                new Equipe("Bordeaux-Bègles",TypeEquipe.Club,"Union Bordeaux-Bègles","/Images/logotop14/UBB.png"),
            };
        }

        public IEnumerable<Equipe> ChargePoule3ChampionsCup()
        {
            return new List<Equipe>
            {
                new Equipe("Racing 92",TypeEquipe.Club,"Le racing 92 est un club de la capitale","/Images/logotop14/Racing.png"),
                new Equipe("Northampton",TypeEquipe.Club,"Club anglais",null),
                new Equipe("Glasgow",TypeEquipe.Club,"Club écossais",null),
                new Equipe("Scarlets",TypeEquipe.Club,"Club gallois",null),
            };
        }

        public IEnumerable<Equipe> ChargePoule4ChampionsCup()
        {
            return new List<Equipe>
            {
                new Equipe("Leicester",TypeEquipe.Club,"Le racing 92 est un club de la capitale",null),
                new Equipe("Stade-Français",TypeEquipe.Club,"Stade-Français Paris","/Images/logotop14/stadeFrançais.png"),
                new Equipe("Munster",TypeEquipe.Club,"Club Irlandais",null),
                new Equipe("Trevise",TypeEquipe.Club,"Club italien",null),
            };
        }

        public IEnumerable<Equipe> ChargePoule5ChampionsCup()
        {
            return new List<Equipe>
            {
                new Equipe("Toulon",TypeEquipe.Club,"Racing Club Toulonnais","/Images/RCT.png"),
                new Equipe("Wasps",TypeEquipe.Club,"Club anglais","/Images/stadeFrançais.png"),
                new Equipe("Bath",TypeEquipe.Club,"Club anglais","/Images/ASM.png"),
                new Equipe("Leinster",TypeEquipe.Club,"Club Irlandais","/Images/UBB.png"),
            };
        }


        public IEnumerable<Equipe> Charge6Nations()
        {
            return new List<Equipe>
            {
                new Equipe("France",TypeEquipe.EquipeNational,"Equipe de France de Rugby","/Images/France.png"),
                new Equipe("Angleterre",TypeEquipe.EquipeNational,"Equipe d'Angleterre","/Images/Angleterre.png"),
                new Equipe("Irlande",TypeEquipe.EquipeNational,"Equipe d'Irlande","/Images/Irlande.png"),
                new Equipe("Pays De Galles",TypeEquipe.EquipeNational,"Equipe du Pays de Galles","/Images/Galles.png"),
                new Equipe("Italie",TypeEquipe.EquipeNational,"Equipe d'Italie","/Images/Italie.png"),

            };
        }

        public IEnumerable<Equipe> Charge4Nations()
        {
            return new List<Equipe>
            {
                new Equipe("Nouvelle-Zélande",TypeEquipe.EquipeNational,"All Blacks","/Images/AllBlacks.png"),
                new Equipe("Argentine",TypeEquipe.EquipeNational,"Equipe d'Argentine","/Images/Argentine.png"),
                new Equipe("Afrique du Sud",TypeEquipe.EquipeNational,"Equipe d'Afrique du Sud","/Images/AfriqueDuSud.png"),
                new Equipe("AUstralie",TypeEquipe.EquipeNational,"Equipe d'AUstralie","/Images/Australie.png"),
            };
        }

        public IEnumerable<Equipe> ChargeEquipeCompetition(string nomCompet)
        {
            List<Equipe> Equipe = new List<Equipe>();
            switch (nomCompet)
            {
                case ("Top14"):
                    Equipe.AddRange(ChargeTop14());
                    return Equipe;

                case ("ProD2"):
                    Equipe.AddRange(ChargeProD2());
                    return Equipe;

                case ("6 Nations"):
                    Equipe.AddRange(Charge6Nations());
                    return Equipe;

                case ("4 Nations"):
                    Equipe.AddRange(Charge4Nations());
                    return Equipe;

                case ("Poule 1 Champions Cup"):
                    Equipe.AddRange(ChargePoule1ChampionsCup());
                    return Equipe;
                case ("Poule 2 Champions Cup"):
                    Equipe.AddRange(ChargePoule2ChampionsCup());
                    return Equipe;
                case ("Poule 3 Champions Cup"):
                    Equipe.AddRange(ChargePoule3ChampionsCup());
                    return Equipe;
                case ("Poule 4 Champions Cup"):
                    Equipe.AddRange(ChargePoule4ChampionsCup());
                    return Equipe;

                case ("Poule 4 Coupe Du Monde"):
                    Equipe.AddRange(ChargePoule4WC());
                    return Equipe;

                case ("Poule 3 Coupe Du Monde"):
                    Equipe.AddRange(ChargePoule3WC());
                    return Equipe;

                case ("Poule 2 Coupe Du Monde"):
                    Equipe.AddRange(ChargePoule2WC());
                    return Equipe;

                case ("Poule 1 Coupe Du Monde"):
                    Equipe.AddRange(ChargePoule1WC());
                    return Equipe;


            }
            return Equipe;
        }

        /// <summary>
        /// On ne peut pas tester l'enregistrement car on ne peut enregistrer dans du code
        /// </summary>
        /// <param name="compet"></param>
        public void EnregistreCompetition(IEnumerable<Competition> compet)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// On ne peut pas tester l'enregistrement car on ne peut enregistrer dans du code
        /// </summary>
        /// <param name="top14"></param>
        public void EnregistreTop14(IEnumerable<Equipe> top14)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// On ne peut pas tester l'enregistrement car on ne peut enregistrer dans du code
        /// </summary>
        /// <param name="proD2"></param>
        public void EnregistreProD2(IEnumerable<Equipe> proD2)
        {
            throw new NotImplementedException();
        }

        public void EnregistreChampionsCup(IEnumerable<CompetitionPouleUnique> championsCup)
        {
            throw new NotImplementedException();
        }


        public void EnregistrePoule1ChampionsCup(IEnumerable<Equipe> poule)
        {
            throw new NotImplementedException();
        }



        public void EnregistrePoule2ChampionsCup(IEnumerable<Equipe> poule)
        {
            throw new NotImplementedException();
        }



        public void EnregistrePoule3ChampionsCup(IEnumerable<Equipe> poule)
        {
            throw new NotImplementedException();
        }



        public void EnregistrePoule4ChampionsCup(IEnumerable<Equipe> poule)
        {
            throw new NotImplementedException();
        }

        public void EnregistrePoule5ChampionsCup(IEnumerable<Equipe> poule)
        {
            throw new NotImplementedException();
        }


        public void Enregistre6Nations(IEnumerable<Equipe> nations)
        {
            throw new NotImplementedException();
        }



        public void Enregistre4Nations(IEnumerable<Equipe> nations)
        {
            throw new NotImplementedException();
        }

        public void EnregistreChallengeCup(IEnumerable<CompetitionPouleUnique> challengeCUp)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Joueur> ChargeEffectifASM()
        {
            return new List<Joueur>
            {
                new Joueur("Fofana", "Wesley", "Française", 52,new Equipe("Clermont-Ferrand",TypeEquipe.Club,"Association sportive Montferrandaise","/Images/logotop14/ASM.png"),"Images/joueur/Fofana.png", Poste.centre),
                new Joueur("Domingo", "Thomas", "Française", 52,new Equipe("Clermont-Ferrand",TypeEquipe.Club,"Association sportive Montferrandaise","/Images/logotop14/ASM.png"), Poste.pilier),

            };
        }

        public void EnregistreEffectifASM(IEnumerable<Joueur> effectif)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Joueur> ChargeEffectifToulon()
        {
            return new List<Joueur>
            {
                new Joueur("Mitchell", "Drew", "Australienne", 69,new Equipe("Toulon",TypeEquipe.Club,"Racing Club Toulonnais","/Images/logotop14/RCT.png"), "Images/joueur/Mitchell.png",Poste.ailier),
                new Joueur("Armitage", "Steffon", "Anglaise", 45, new Equipe("Toulon",TypeEquipe.Club,"Racing Club Toulonnais","/Images/logotop14/RCT.png"), Poste.pilier),

            };
        }

        public void EnregistreEffectifToulon(IEnumerable<Joueur> effectif)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Joueur> ChargeEffectifAurillac()
        {
            return new List<Joueur>
            {
                new Joueur("Petitjean", "Maxime", "Français", 0,new Equipe("Aurillac",TypeEquipe.Club,"Club de rugby de la ville d'Albi","/Images/logoprod2/aurillac.png"), Poste.demiOuverture),
                new Joueur("Boisset", "Paul", "Français", 0,new Equipe("Aurillac",TypeEquipe.Club,"Club de rugby de la ville d'Albi","/Images/logoprod2/aurillac.png"), Poste.pilier),

            };
        }

        public void EnregistreEffectifAurillac(IEnumerable<Joueur> effectif)
        {
            throw new NotImplementedException();
        }

        public void EnregistreUser(IEnumerable<UtilisateurInscrit> users)
        {
            listeUser.AddRange(users);
        }

        public List<UtilisateurInscrit> ChargeUser()
        {
            return listeUser;
        }

       

        public void EnregistreWordCup(IEnumerable<CompetitionPouleUnique> WordCup)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equipe> ChargePoule1WC()
        {
            return new List<Equipe>
            {
                new Equipe("Irlande",TypeEquipe.EquipeNational,"Equipe d'Irlande","/Images/Irlande.png"),
                new Equipe("France",TypeEquipe.EquipeNational,"Equipe de France de Rugby","/Images/France.png"),
                new Equipe("Italie",TypeEquipe.EquipeNational,"Equipe d'Italie","/Images/Italie.png"),
                new Equipe("Roumanie",TypeEquipe.EquipeNational,"Equipe de Roumanie","/Images/Roumanie.png"),
                new Equipe("Canada",TypeEquipe.EquipeNational,"Equipe du Canada","/Images/Canada.png"),
            };
        }

        public void EnregistrePoule1WC(IEnumerable<Equipe> poule)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equipe> ChargePoule2WC()
        {
            return new List<Equipe>
            {
                new Equipe("Nouvelle-Zélande",TypeEquipe.EquipeNational,"All Blacks","/Images/AllBlacks.png"),
                new Equipe("Argentine",TypeEquipe.EquipeNational,"Equipe d'Argentine","/Images/Argentine.png"),
                new Equipe("Afrique du Sud",TypeEquipe.EquipeNational,"Equipe d'Afrique du Sud","/Images/AfriqueDuSud.png"),
                new Equipe("AUstralie",TypeEquipe.EquipeNational,"Equipe d'AUstralie","/Images/Australie.png"),
                new Equipe("AUstralie",TypeEquipe.EquipeNational,"Equipe d'AUstralie","/Images/Australie.png"),
            };
        }

        public void EnregistrePoule2WC(IEnumerable<Equipe> poule)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equipe> ChargePoule3WC()
        {
            return new List<Equipe>
            {
                new Equipe("Nouvelle-Zélande",TypeEquipe.EquipeNational,"All Blacks","/Images/AllBlacks.png"),
                new Equipe("Argentine",TypeEquipe.EquipeNational,"Equipe d'Argentine","/Images/Argentine.png"),
                new Equipe("Afrique du Sud",TypeEquipe.EquipeNational,"Equipe d'Afrique du Sud","/Images/AfriqueDuSud.png"),
                new Equipe("AUstralie",TypeEquipe.EquipeNational,"Equipe d'AUstralie","/Images/Australie.png"),
                new Equipe("AUstralie",TypeEquipe.EquipeNational,"Equipe d'AUstralie","/Images/Australie.png"),
            };
        }

        public void EnregistrePoule3WC(IEnumerable<Equipe> poule)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equipe> ChargePoule4WC()
        {
            return new List<Equipe>
            {
                new Equipe("Irlande",TypeEquipe.EquipeNational,"Equipe d'Irlande","/Images/Irlande.png"),
                new Equipe("France",TypeEquipe.EquipeNational,"Equipe de France de Rugby","/Images/France.png"),
                new Equipe("Italie",TypeEquipe.EquipeNational,"Equipe d'Italie","/Images/Italie.png"),
                new Equipe("Roumanie",TypeEquipe.EquipeNational,"Equipe de Roumanie","/Images/Roumanie.png"),
                new Equipe("Canada",TypeEquipe.EquipeNational,"Equipe du Canada","/Images/Canada.png"),
            };
        }

        public void EnregistrePoule4WC(IEnumerable<Equipe> poule)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Joueur> ChargerJoueurEquipe(Equipe e)
        {
            List<Joueur> effectif = new List<Joueur>();
            switch (e.Nom)
            {
                case ("Clermont-Ferrand"):
                    effectif.AddRange(ChargeEffectifASM());
                    return effectif;

                case ("Agen"):
                    effectif.AddRange(ChargeEffectifASM());
                    return effectif;

                case ("Brive"):
                    effectif.AddRange(ChargeEffectifASM());
                    return effectif;

                case ("Toulon"):
                    effectif.AddRange(ChargeEffectifToulon());
                    return effectif;
                case ("Aurillac"):
                    effectif.AddRange(ChargeEffectifAurillac());
                    return effectif;

            }
            return effectif;
        }

        IEnumerable<Equipe> IDataManager.ChargeEquipeNational()
        {
            List<Equipe> EquipeNational = new List<Equipe>();
            EquipeNational.AddRange(Charge4Nations());
            EquipeNational.AddRange(Charge6Nations());
            return EquipeNational;
        }

        IEnumerable<Equipe> IDataManager.ChargeClub()
        {
            List<Equipe> equipe = new List<Equipe>();
            equipe.AddRange(ChargeTop14());
            equipe.AddRange(ChargeProD2());
            equipe.AddRange(ChargePoule1ChampionsCup());
            equipe.AddRange(ChargePoule2ChampionsCup());
            equipe.AddRange(ChargePoule3ChampionsCup());
            equipe.AddRange(ChargePoule4ChampionsCup());
            equipe.AddRange(ChargePoule5ChampionsCup());
            return equipe;
        }

        public List<CompetitionPouleUnique> ChargePouleCompetition(String Nom)
        {
            List<CompetitionPouleUnique> Poule = new List<CompetitionPouleUnique>();

            switch (Nom)
            {
                case ("Champions Cup"):
                    Poule.AddRange(ChargeChampionsCup());
                    return Poule;

                case ("Challenge Cup"):
                    Poule.AddRange(ChargeChampionsCup());
                    return Poule;

                case ("Coupe du monde"):
                    Poule.AddRange(ChargeWordCup());
                    return Poule;

            }
            return Poule;
        }




    }




  
}
