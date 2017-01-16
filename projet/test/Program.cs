using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using métier;
using System.IO;
using Persistance;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Création d'équipes
            Equipe asm = new Equipe("Clermont-Ferrand", TypeEquipe.Club, "Association Sportive Montferrandaise", "/Images/logotop14/ASM.png");
            Equipe france = new Equipe("France", TypeEquipe.EquipeNational, "Equipe de France de rugby", "/Images/France");
            Equipe toulon = new Equipe("Toulon", TypeEquipe.Club, "RC Toulon triple champion d'europe", "/Images/logotop14/toulon.png");
            Equipe AllBlack = new Equipe("New-Zéland", TypeEquipe.EquipeNational, "La Nouvelle-Zélande est la meilleure équipe du monde", "/Images/AllBlack.png");
            Equipe italie = new Equipe("Italie", TypeEquipe.EquipeNational, "italia", "/photo");
            Equipe toulouse = new Equipe("Stade Toulousain", TypeEquipe.Club, "toulouse", "/photo");


            ///Création de Joueur
            Joueur fofana = new Joueur("Fofana", "Wesley", "Française", 52, asm, Poste.centre);
            Joueur Mitchell = new Joueur("Mitchell", "Drew", "Australienne", 69, toulon, Poste.ailier);
            Joueur Domingo = new Joueur("Domingo", "Thomas", "Française", 12, asm, Poste.pilier);
            Joueur Michalak = new Joueur("Michalak", "Fred", "Française", 72, toulon, Poste.demiOuverture);
            Joueur fickou = new Joueur("Fickou", "Gael", "Francais", 25, toulouse, Poste.centre);


            ///Création de Trophés
            Trophes brennus2010 = new Trophes(new CompetitionPouleUnique("Championnat de France de rugby", TypeEquipe.Club, "Top14", "/Images/logoCompet/Top14.png"), 2010, "Brennus", new Equipe("Clermont-Ferrand", TypeEquipe.Club, "Association Sportive Montferrandaise", "/Images/logotop14/ASM.png"));
           

            ///Création de Compétition
            CompetitionPouleUnique top14 = new CompetitionPouleUnique("Championnat de France de rugby", TypeEquipe.Club, "Top14", "/Images/logoCompet/Top14.png");
            CompetitionAPoule coupeDuMonde = new CompetitionAPoule("coupe du monde", TypeEquipe.EquipeNational, "Coupe du Monde", "/Images/logoCompet/coupedumonde.png");
            CompetitionAPoule ChampionsCup = new CompetitionAPoule("Coupe d'europe", TypeEquipe.Club, "Champions Cup", "/Images/logoCompet/coupedumonde.png");

            ///Création D'utilisateur
            UtilisateurInscrit baba = new UtilisateurInscrit("13051996", "babadu15", Sexe.Homme, asm, france);
            Utilisateur anonyme = new Utilisateur();
            Moderateur admin = new Moderateur("12041957", "AdminOuf", Sexe.Femme, toulon, AllBlack);

            ///Création d'un stubData
            StubDataManager stub = new StubDataManager();

            ///Création d'un match et d'un résultat
            Match match = new Match(asm, toulouse, 1, top14);
            resultat result = new resultat(30, 23, 5, 2);
            ///Création d'un Manager
            Manager m = new Manager(stub);


            ///Création de commmentaire
            Commentaire combabaASM = new Commentaire("Aller l'ASM", new DateTime(2016, 5, 20), baba);


            Console.WriteLine("\n///Test sur Joueur");
            Console.WriteLine(fofana.ToString());
            fofana.ajouterTrophe(brennus2010);
            foreach (Trophes t in fofana.Palmares)
            {
                Console.WriteLine(t.ToString());
            }
            fofana.ajouterCommentaire(combabaASM);
            foreach (Commentaire c in fofana.Commentaires)
            {
                Console.WriteLine(c.ToString());
            }



            Console.WriteLine("\n///Test sur Equipe");
            Console.WriteLine("\n Test ajout de joueur");
            asm.ajouterJoueur(fofana);
            asm.ajouterJoueur(Domingo);
            foreach (Joueur j in asm.Effectif)
            {
                Console.WriteLine(j.ToString());
            }
            Console.WriteLine("\n Test suppression joueur");
            asm.supprimerJoueur(Domingo);
            foreach (Joueur j in asm.Effectif)
            {
                Console.WriteLine(j.ToString());
            }

            Console.WriteLine("\n Test ajout trophes");
            toulon.ajouterPalmares(new Trophes(ChampionsCup, 2015, "coupe d'europe",toulon));
            toulon.ajouterPalmares(new Trophes(ChampionsCup,2014, "coupe d'europe", toulon));
            toulon.ajouterPalmares(new Trophes(ChampionsCup, 2013, "coupe d'europe", toulon));
            toulon.ajouterPalmares(new Trophes(top14, 2014, "brennus", toulon));
            foreach (Trophes t in toulon.Palmares)
            {
                Console.WriteLine(t.ToString());
            }

            asm.ajouterCommentaire(combabaASM);
            Console.WriteLine("\n test Ajout d'un comentaire");
            foreach (Commentaire c in asm.Commentaires)
            {
                Console.WriteLine(c.ToString());
            }





            Console.WriteLine("\n///Test sur compétitionPouleUnique");
            Console.WriteLine("\n Test ajout équipe ");
            top14.AjouterEquipe(asm);
            top14.AjouterEquipe(toulon);
            foreach (Equipe e in top14.Equipes)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\n Test suppression équipe");
            top14.SupprimerEquipe(toulon);
            foreach (Equipe e in top14.Equipes)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\n///Ajout d'un match");
            top14.AjouterUnMatch(match);
            foreach (Match m2 in top14.Calendrier)
            {
                Console.WriteLine(m2.ToString());
            }
            Console.WriteLine("\n Ajout d'un résulat");
            Console.WriteLine("\n classement avant :");
            foreach (EquipePoints p in top14.Points)
            {
                Console.WriteLine("\n" + p.Equipe.Nom + p.Points.ToString());
            }
            Match m3 = new Match(asm, toulon, 8, top14);
            resultat resultatm3 = new resultat(89, 67, 12, 9);
            top14.AjouterUnResultat(m3, resultatm3);
            foreach (Match m4 in top14.Calendrier)
            {
                Console.WriteLine(m4.ToString());
            }
            Console.WriteLine("\n classement après :");
            foreach (EquipePoints p in top14.Points)
            {
                Console.WriteLine("\n" + p.Equipe.Nom + " " + p.Points);
            }


            Console.WriteLine("\n///Test sur Compétition à Poule");
            coupeDuMonde.ToString();
            coupeDuMonde.AjouterUnePoules("poulesA", new CompetitionPouleUnique("Poules A de la Coupe du monde", coupeDuMonde.TypeEquipeParticipante, "Poule A", "/Images/logoCompet/coupedumonde.png"));
            coupeDuMonde.AjouterUnePoules("poulesB", new CompetitionPouleUnique("Poules B de la Coupe du monde", coupeDuMonde.TypeEquipeParticipante, "Poule B", "/Images/logoCompet/coupedumonde.png"));
            foreach (CompetitionPouleUnique poule in coupeDuMonde.Poules)
            {
                Console.WriteLine(poule.ToString());
            }
            coupeDuMonde.AjouterEquipe(france, "Poule A");
            coupeDuMonde.AjouterEquipe(AllBlack, "Poule B");
            foreach (CompetitionPouleUnique p in coupeDuMonde.Poules)
            {
                foreach (Equipe e in p.Equipes)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            coupeDuMonde.SupprimerEquipe(france);
            foreach (CompetitionPouleUnique p in coupeDuMonde.Poules)
            {
                foreach (Equipe e in p.Equipes)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            Console.WriteLine("\n ////// /////Tests avec le manager");


            Console.WriteLine("\n Test de la méthode getCalendierEquipe pour savoir si elle retourne ce qu'in faut");
            m.CurrentUser = anonyme;
            foreach (Match testMatch in m.getCalendrierEquipe(toulon))
            {
                Console.WriteLine(testMatch.ToString());
            }

            Console.WriteLine("\n Test de la méthode getCalendrierCompet");
            foreach (Match testMatch in m.getClendrierCompet(top14))
            {
                Console.WriteLine(testMatch.ToString());
            }

            Console.WriteLine("\n Test de la méthode getEffectifEquipe");
            foreach (Joueur j in m.getEffectifEquipe(asm))
            {
                Console.WriteLine(j.ToString());
            }

            Console.WriteLine("\n Test sur la méthode getResultatCompet");
            foreach (Match matchTest in m.getResulatsCompet(top14))
            {
                Console.WriteLine(matchTest.ToString());
            }

            Console.WriteLine("\n Test sur la méthode getResulatEquipe");
            foreach (Match matchTest in m.getResultatEquipe(asm))
            {
                Console.WriteLine(matchTest.ToString());
            }

            Console.WriteLine("\n ////////////Test avec un simple Utilisateur");
            Console.WriteLine("\n///Test pour ajout d'une équipe dans une compétition à poule unique");
            m.AddEquipeCompetAPouleUnique(top14, toulouse);
            foreach (Equipe e in top14.Equipes)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\n ///Test pour l'ajout d'une Equipe dans une poule d'une compétition à poule");
            m.CurrentUser = anonyme;
            m.AddEquipeCompetitionAPoule(coupeDuMonde, italie, coupeDuMonde.Poules[0].Nom);
            foreach (CompetitionPouleUnique c in coupeDuMonde.Poules)
            {
                foreach (Equipe e in c.Equipes)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            Console.WriteLine("\n///Test Pour ajouter une compétition");
            m.AjouterCompetition(ChampionsCup);
            foreach (Competition c in m.CompetitionsROC)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("\n///Test pour ajouter un joueur à une équipe");
            m.AjouterJoueur(fickou, toulouse);
            foreach (Joueur j in toulouse.Effectif)
            {
                Console.WriteLine(j.ToString());
            }
            Console.WriteLine("\n /// Test pour supprimer une équipe d'une compétiotion à poules");
            m.SupprimerEquipeCompetitionAPoule(coupeDuMonde, france);
            foreach (CompetitionPouleUnique c in coupeDuMonde.Poules)
            {
                foreach (Equipe e in c.Equipes)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            Console.WriteLine("\n Test pour supprimer un joueur d'une équipe");
            m.SupprimerJoueur(fickou, toulouse);
            foreach (Joueur j in toulouse.Effectif)
            {
                Console.WriteLine(j.ToString());
            }
            Console.WriteLine("\n///Test pour Ajouter un résultat");

            foreach (Match mat in m.getResulatsCompet(top14))
            {
                Console.WriteLine(mat.ToString());
            }
            Console.WriteLine("\n///Test pour supprimer une compétition");
            m.SupprimerCompetition(ChampionsCup);
            foreach (Competition c in m.CompetitionsROC)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("\n///Test pour supprimer un équipe d'une compétition a poule unique");
            m.SupprimerEquipeCompetAPouleUnique(top14, toulon);
            foreach (Equipe e in top14.Equipes)
            {
                Console.WriteLine(e.ToString());
            }




            Console.WriteLine("\n /////////////// Test sur un utilisateur inscrit");
            Console.WriteLine("\n///Test pour ajout d'une équipe dans une compétition à poule unique");
            m.CurrentUser = baba;
            m.AddEquipeCompetAPouleUnique(top14, toulouse);
            foreach (Equipe e in top14.Equipes)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\n ///Test pour l'ajout d'une Equipe dans une poule d'une compétition à poule");
            m.AddEquipeCompetitionAPoule(coupeDuMonde, italie, coupeDuMonde.Poules[0].Nom);
            foreach (CompetitionPouleUnique c in coupeDuMonde.Poules)
            {
                foreach (Equipe e in c.Equipes)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            Console.WriteLine("\n///Test Pour ajouter une compétition");
            m.CurrentUser = anonyme;
            m.AjouterCompetition(ChampionsCup);
            foreach (Competition c in m.CompetitionsROC)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("\n///Test pour ajouter un joueur à une équipe");
            m.AjouterJoueur(fickou, toulouse);
            foreach (Joueur j in toulouse.Effectif)
            {
                Console.WriteLine(j.ToString());
            }

            Console.WriteLine("\n///Test pour Ajouter un résultat");



            Console.WriteLine("\n///Test pour Ajouter un résultat");
            m.AjouterResultat(match, result);
            foreach (Match mat in m.getResulatsCompet(top14))
            {
                Console.WriteLine(mat.ToString());
            }
            Console.WriteLine("\n///Test pour supprimer une compétition");
            m.SupprimerCompetition(ChampionsCup);
            foreach (Competition c in m.CompetitionsROC)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("\n///Test pour supprimer un équipe d'une compétition a poule unique");
            m.SupprimerEquipeCompetAPouleUnique(top14, toulon);
            foreach (Equipe e in top14.Equipes)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\n///Test pour supprimer une équipe d'une compétition à poule");
            m.SupprimerEquipeCompetitionAPoule(coupeDuMonde, france);
            foreach (CompetitionPouleUnique c in coupeDuMonde.Poules)
            {
                foreach (Equipe e in c.Equipes)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            Console.WriteLine("\n///Test pour supprmer un joueur d'une équipe");
            m.SupprimerJoueur(fickou, toulouse);
            foreach (Joueur j in toulouse.Effectif)
            {
                Console.WriteLine(j.ToString());
            }




            Console.WriteLine("\n ////////////Test avec un modérateur");
            Console.WriteLine("\n///Test pour ajout d'une équipe dans une compétition à poule unique");
            m.CurrentUser = admin;
            m.AddEquipeCompetAPouleUnique(top14, toulouse);
            foreach (Equipe e in top14.Equipes)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\n ///Test pour l'ajout d'une Equipe dans une poule d'une compétition à poule");
            m.AddEquipeCompetitionAPoule(coupeDuMonde, italie, coupeDuMonde.Poules[0].Nom);
            foreach (CompetitionPouleUnique c in coupeDuMonde.Poules)
            {
                foreach (Equipe e in c.Equipes)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            Console.WriteLine("\n///Test Pour ajouter une compétition");
            m.AjouterCompetition(ChampionsCup);
            foreach (Competition c in m.CompetitionsROC)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("\n///Test pour ajouter un joueur à une équipe");
            m.AjouterJoueur(fickou, toulouse);
            foreach (Joueur j in toulouse.Effectif)
            {
                Console.WriteLine(j.ToString());
            }

            Console.WriteLine("\n///Test pour Ajouter un résultat");
            top14.AjouterUnMatch(match);
            m.AjouterResultat(match, result);
            foreach (Match mat in m.getResulatsCompet(top14))
            {
                Console.WriteLine(mat.ToString());
            }
            Console.WriteLine("\n///Test pour supprimer une compétition");
            m.SupprimerCompetition(ChampionsCup);
            foreach (Competition c in m.CompetitionsROC)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("\n///Test pour supprimer un équipe d'une compétition a poule unique");
            m.SupprimerEquipeCompetAPouleUnique(top14, toulouse);
            foreach (Equipe e in top14.Equipes)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\n///Test pour supprimer une équipe d'une compétition à poule");
            m.SupprimerEquipeCompetitionAPoule(coupeDuMonde, italie);
            foreach (CompetitionPouleUnique c in coupeDuMonde.Poules)
            {
                foreach (Equipe e in c.Equipes)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            Console.WriteLine("\n///Test pour supprmer un joueur d'une équipe");
            m.SupprimerJoueur(fickou, toulouse);
            foreach (Joueur j in toulouse.Effectif)
            {
                Console.WriteLine(j.ToString());
            }
            
        }

    }
    
}













