using métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
      public class Manager
    {
        
        /// <summary>
        /// Liste des utilisateurs inscrits de l'application
        /// </summary>
        public List<UtilisateurInscrit> users= new List<UtilisateurInscrit>();

        /// <summary>
        /// ReadOnlyCollection des compétition de l'application qui encapsule la liste Competitions
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<Competition> CompetitionsROC
        {
            get;
            private set;
        }
        /// <summary>
        ///  Liste des compétition de l'application
        /// </summary>
        public List<Competition> Competitions = new List<Competition>();
        /// <summary>
        /// Liste des modérateurs
        /// </summary>
        public List<Moderateur> admins = new List<Moderateur>();

        /// <summary>
        /// ReadOnlyCollection d'équipe de l'application qui encapsule la liste Competitions
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<Equipe> EquipeCompetROC
        {
            get;
            private set;
        }
        /// <summary>
        ///  Liste d'équipe d'une compétition de l'application
        /// </summary>
        private List<Equipe> EquipeCompet = new List<Equipe>();

        public System.Collections.ObjectModel.ReadOnlyCollection<Equipe> AllEquipeROC
        {
            get;
            private set;
        }
        /// <summary>
        ///  Liste de toutes les équipes 
        /// </summary>
        private List<Equipe> AllEquipe = new List<Equipe>();

        /// <summary>
        /// ReadOnlyCollection d'équipe de l'application qui encapsule la liste Competitions
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<CompetitionPouleUnique> PouleCompetROC
        {
            get;
            private set;
        }
        /// <summary>
        ///  Liste d'équipe d'une compétition de l'application
        /// </summary>
        private List<CompetitionPouleUnique> PouleCompet = new List<CompetitionPouleUnique>();

        /// <summary>
        /// Liste de Match d'une équipe de la compétition
        /// </summary>
        private List<Match> Matchs = new List<Match>();
        
        public System.Collections.ObjectModel.ReadOnlyCollection<Match> MatchsROC
        {
            get;
            private set;
        }

        /// <summary>
        /// ReadOnlyCollection d'équipe de l'application qui encapsule la liste Competitions
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<Joueur> EffectifROC
        {
            get;
            private set;
        }
        /// <summary>
        ///  Liste d'équipe d'une compétition de l'application
        /// </summary>
        private List<Joueur> Effectif = new List<Joueur>();

        /// <summary>
        /// Utilisateur de l'application a un moment donné
        /// </summary>
        public Utilisateur CurrentUser { get; set; }

        /// <summary>
        /// attribut IdataManager qui permet de relier le métier a la persistance
        /// </summary>
        private IDataManager DataManager { get; set; }

        public System.Collections.ObjectModel.ReadOnlyCollection<Equipe> EquipeNatROC
        {
            get;
            private set;
        }
        public List<Equipe> Equipenat = new List<Equipe>();

        /// <summary>
        /// Liste de match d'une equipe
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<Match> MatchsTriesROC
        {
            get;
            private set;
        }
        private List<Match> MatchsTries = new List<Match>();

        /// <summary>
        /// Liste de résultat d'une équipe
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<Match> ResulatsEquipeROC
        {
            get;
            private set;
        }
        private List<Match> ResultatsEquipe = new List<Match>();

        /// <summary>
        /// Liste de Trophés
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<Trophes> AllTrophesROC
        {
            get;
            private set;
        }
        private List<Trophes> AllTrophes = new List<Trophes>();

        public System.Collections.ObjectModel.ReadOnlyCollection<Trophes> TrophesROC
        {
            get;
            private set;
        }
        private List<Trophes> Trophes = new List<Trophes>();

        public System.Collections.ObjectModel.ReadOnlyCollection<EquipePoints> ClassementROC
        {
            get;
            private set;
        }
        private List<EquipePoints> Classement = new List<EquipePoints>();

        /// <summary>
        /// Constructeur de manager prenant en paramètre un IDataManager
        /// </summary>
        /// <param name="datamanager"></param>
        /// 
        public Manager(IDataManager datamanager)
        {
            DataManager = datamanager;
            EquipeCompetROC = new System.Collections.ObjectModel.ReadOnlyCollection<Equipe>(EquipeCompet);
            CompetitionsROC = new System.Collections.ObjectModel.ReadOnlyCollection<Competition>(Competitions);
            PouleCompetROC = new System.Collections.ObjectModel.ReadOnlyCollection<CompetitionPouleUnique>(PouleCompet);
            AllEquipeROC = new System.Collections.ObjectModel.ReadOnlyCollection<Equipe>(AllEquipe);
            EffectifROC = new System.Collections.ObjectModel.ReadOnlyCollection<Joueur>(Effectif);
            EquipeNatROC= new System.Collections.ObjectModel.ReadOnlyCollection<Equipe>(Equipenat);
            MatchsROC = new System.Collections.ObjectModel.ReadOnlyCollection<Match>(Matchs);
            MatchsTriesROC = new System.Collections.ObjectModel.ReadOnlyCollection<Match>(MatchsTries);
            ResulatsEquipeROC = new System.Collections.ObjectModel.ReadOnlyCollection<Match>(ResultatsEquipe);
            AllTrophesROC = new System.Collections.ObjectModel.ReadOnlyCollection<Trophes>(AllTrophes);
            TrophesROC = new System.Collections.ObjectModel.ReadOnlyCollection<Trophes>(Trophes);
            ClassementROC = new System.Collections.ObjectModel.ReadOnlyCollection< EquipePoints > (Classement);
            ChargeCompetition();
            users = DataManager.ChargeUser();
            CurrentUser = new Utilisateur();
            admins.Add(new Moderateur("admin", "admin"));
        }


        public UtilisateurInscrit Retourneutilisateur(string pseudo, string mdp)
        {
            foreach (UtilisateurInscrit u in users)
            {
                if (u.Pseudo.Equals(pseudo) && u.MotDePasse.Equals(mdp))
                {
                    return u;
                }
            }
            foreach(Moderateur m in admins)
            {
                if(m.Pseudo.Equals(pseudo) && m.MotDePasse.Equals(mdp))
                {
                    return m;
                }
            }
            return null;

        }
        /// <summary>
        /// méthode qui permet à un utilisateur de se connecter.
        /// On regarde si l'utilisateur est dans la liste des utilisateurs.
        /// </summary>
        /// <param name="pseudo">pseudo </param>
        /// <param name="mdp">mdp</param>
        /// <returns>true or false</returns>
        public bool seconnecter(string pseudo, string mdp)
        {
            foreach(UtilisateurInscrit u in users)
            {
                if (u.Pseudo.Equals(pseudo) && u.MotDePasse.Equals(mdp))
                {
                    CurrentUser = u;
                    return true;
                }
            }
            foreach(Moderateur m in admins)
            {
                if (m.Pseudo.Equals(pseudo) && m.MotDePasse.Equals(mdp))
                {
                    CurrentUser = m;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Cette méthode permet à un utilisateur de s'inscrire. On vérifie que l'utilisateur n'est pas dans la liste d'user.
        /// </summary>
        /// <param name="mdp">mdp</param>
        /// <param name="pseudo">pseudo</param>
        /// <param name="sexe">sexe</param>
        /// <param name="equipefav">equipe favorite</param>
        /// <param name="equipenatfav">equipe nationale favorite</param>
        /// <returns>true or false</returns>
        public bool InscriptionUser(string mdp, string pseudo, Sexe sexe,string equipefav,string equipenatfav)
        {
            Equipe equipe = null;
            Equipe equipenat = null;
            this.ChargeAllEquipe();
            foreach (Equipe e in AllEquipeROC)
            {
                if (e.Equals(equipefav))
                {
                    equipe = e;
                }
            }
            foreach (Equipe e in AllEquipeROC)
            {
                if (e.Nom.Equals(equipenatfav))
                {
                    equipenat = e;
                }
            }

            UtilisateurInscrit user = new UtilisateurInscrit(mdp, pseudo, sexe,equipe,equipenat);
            users = DataManager.ChargeUser();
            if (users == null)
            {
                users.Add(user);
                return true;
            }
            else
            {
                foreach (UtilisateurInscrit u in users)
                {
                    if (u.Pseudo.Equals(user.Pseudo))
                    {
                        return false;
                    }
                }

                users.Add(user);
                DataManager.EnregistreUser(users);
                return true;
            }
            

        }

        /// <summary>
        /// Charge touts les Trophés de la Compétition
        /// </summary>
        public void ChargeAllTrophe()
        {
            AllTrophes.Clear();
            AllTrophes.AddRange(DataManager.ChargePalmares());
        }

        /// <summary>
        /// Charge dans une liste la l'historique des trophés d'une compétition
        /// </summary>
        /// <param name="c"></param>
        public void ChargeTropheCompetition(Competition c)
        {
            AllTrophes.Clear();
            ChargeAllTrophe();
            Trophes.Clear();
            foreach (Trophes t in AllTrophes)
            {
                if (c.Nom.Equals(t.NomCompet.Nom))
                {
                    Trophes.Add(t);
                }
            }
        }
        /// <summary>
        /// Charge dans une liste les trophé d'une équipe
        /// </summary>
        /// <param name="e"></param>
        public void ChargeTropheEquipe(Equipe e)
        {
            AllTrophes.Clear();
            ChargeAllTrophe();
            Trophes.Clear();
            foreach (Trophes t in AllTrophes)
            {
                if (e.Nom.Equals(t.EquipeGagnante.Nom))
                {
                    Trophes.Add(t);
                }
            }
        }

        /// <summary>
        /// Permet de charger toutes les équipes de toutes les compétitions.
        /// </summary>
        public void ChargeAllEquipe()
        {
            if (DataManager != null)
            {
                AllEquipe.Clear();
                AllEquipe.AddRange(DataManager.ChargeClub());
            }
        }
        /// <summary>
        /// Permet de charger les équipes nationales
        /// </summary>
        public void ChargeEquipeNat()
        {
            if (DataManager != null)
            {
                Equipenat.Clear();
                Equipenat.AddRange(DataManager.ChargeEquipeNational());

            }
        }
        /// <summary>
        /// Permet de Charger la liste de tous les matchs
        /// </summary>
        public void ChargeMatch()
        {
            Matchs.Clear();
            Matchs.AddRange(DataManager.ChargeMatchs());
        }


        /// <summary>
        /// Methode permettant de charger toutes les compétitions
        /// </summary>
        public void ChargeCompetition()
        {
            if(DataManager != null)
            {
                Competitions.Clear();
                Competitions.AddRange(DataManager.ChargeCompetition());
            }
        }

        /// <summary>
        /// Méthode qui permet de charger la liste des poules d'une compétition
        /// </summary>
        /// <param name="Nom">nom de la compétitions</param>
        public void ChargeCompetitionAPoule(string Nom)
        {
            if (DataManager != null)
            {
                PouleCompet.Clear();
                PouleCompet.AddRange(DataManager.ChargePouleCompetition(Nom));
            }

        }
        /// <summary>
        /// Permet de charger l'effectif de l'équipe dont le nom est passé en paramètres
        /// </summary>
        /// <param name="Nom">nom de l'équipe</param>
        public void ChargeEffectif(Equipe e)
        {
             if (DataManager != null)
            {
                Effectif.Clear();
                Effectif.AddRange(DataManager.ChargerJoueurEquipe(e));
            }
        }
        /// <summary>
        /// charge la liste des équipes de la compétitions
        /// </summary>
        /// <param name="Nom"></param>
        public void ChargeEquipe(string Nom)
        {
            if (DataManager != null)
            {
                EquipeCompet.Clear();
                EquipeCompet.AddRange(DataManager.ChargeEquipeCompetition(Nom));
            }
        }

       

        /// <summary>
        /// Permet de charger les matchs d'une équipe
        /// </summary>
        /// <param name="e"></param>
        public void ChargeMatchsEquipe(Equipe e)
        {
            Matchs.Clear();
            ChargeMatch();
            MatchsTries.Clear();
            foreach(Match m in Matchs)
            {
                if (m.Joue == false)
                {
                    if (m.EquipeA.Nom.Equals(e.Nom) || m.EquipeB.Nom.Equals(e.Nom))
                    {
                        MatchsTries.Add(m);
                    }

                }
                
            }
        }
        /// <summary>
        /// Permet de charger les match d'une compétition
        /// </summary>
        /// <param name="c"></param>
        public void ChargeMatchsCompetition(Competition c)
        {
            Matchs.Clear();
            ChargeMatch();
            MatchsTries.Clear();
            foreach(Match m in Matchs)
            {
                if (m.Joue == false)
                {
                    if (m.Competition.Nom.Equals(c.Nom))
                    {
                        MatchsTries.Add(m);
                    }
                }
            }
        }
        /// <summary>
        /// Permet de Charger le classement d'une compétition
        /// </summary>
        /// <param name="c"></param>
        public void ChargeClassementCompetition(CompetitionPouleUnique c)
        {
            FabriqueMajPoints fabrique = new FabriqueMajPoints();
            IMAJ_Points maj = fabrique.FabriqueMaj(c);
            EquipeCompet.Clear();
            ChargeEquipe(c.Nom);
            c.classement.Clear();
            foreach(Equipe e in EquipeCompet)
            {
                c.classement.Add(e, 0);
            }
            Matchs.Clear();
            ChargeMatch();
            foreach(Match m in Matchs)
            {
                if (m.Joue == true && m.Competition.Nom.Equals(c.Nom))
                {
                    maj.MajPoints(c, m);
                }
            }
            Classement.Clear();
            Classement.AddRange(c.Points);     
        }

        
        /// <summary>
        /// Pemet de charger la liste des résulats d'une équipe.
        /// </summary>
        /// <param name="e"></param>
        public void ChargerResultatsEquipe(Equipe e)
        {
            ChargeMatch();
            ResultatsEquipe.Clear();
            foreach (Match m in Matchs)
            {
                if (m.EquipeA.Nom.Equals(e.Nom) || m.EquipeB.Nom.Equals(e.Nom))
                {
                   
                    if (m.Joue == true)
                    {
                        ResultatsEquipe.Add(m);
                    }   
                }

            }
        }
        

        /// <summary>
        /// Permet d'enregistrer les compétitions
        /// </summary>
        public void EnregistreCompetition()
        {
            DataManager.EnregistreCompetition(Competitions);
        }

        /// <summary>
        /// Methode permettant de récuperer le calendrier d'une equipe
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public IEnumerable<Match> getCalendrierEquipe(Equipe e)
        {
            return Competitions.SelectMany(c => c.Calendrier.Where(match => (e.Equals(match.EquipeA) || e.Equals(match.EquipeB) && match.Joue==false ))).OrderByDescending(m => m.Journée);
        }
        /// <summary>
        /// Methode Permettant de récuperer le calendrier d'une compétition
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public IEnumerable<Match> getClendrierCompet(Competition c)
        {
            return c.Calendrier.Where(m=> m.Joue=false);
        }
        /// <summary>
        /// Permet de recuperer les résultats d'une équipe
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public IEnumerable<Match> getResultatEquipe(Equipe e)
        {
            return Competitions.SelectMany(c => c.Calendrier.Where(match => (e.Equals(match.EquipeA) || e.Equals(match.EquipeB) && match.Joue == true))).OrderByDescending(m => m.Journée);
        }
        /// <summary>
        /// Permet de recuperer les resulats d'une competition
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public IEnumerable<Match> getResulatsCompet(Competition c)
        {
            return c.Calendrier.Where(m => m.Joue = true);
        }

        /// <summary>
        /// Methode permettant a un moderateur d'ajouter une équipe à une compétition a poule unique
        /// </summary>
        /// <param name="c"></param>
        /// <param name="e"></param>
        public void  AddEquipeCompetAPouleUnique(CompetitionPouleUnique c, Equipe e)
        {
            if(CurrentUser is Moderateur)
            {
                c.AjouterEquipe(e);
            }
            else { return; }
        }

        /// <summary>
        /// Methode pour supprimer une équipe d'une Compétition a poule unique
        /// </summary>
        /// <param name="c"></param>
        /// <param name="e"></param>
        public void SupprimerEquipeCompetAPouleUnique(CompetitionPouleUnique c,Equipe e)
        {
            if(CurrentUser is Moderateur)
            {
                c.SupprimerEquipe(e);
            }
            else { return; }
        }
        /// <summary>
        /// Ajouter Equipe à une compétition à poule
        /// </summary>
        /// <param name="c"></param>
        /// <param name="e"></param>
        /// <param name="nom"></param>
        public void AddEquipeCompetitionAPoule(CompetitionAPoule c, Equipe e, string nom)
        {
            if (CurrentUser is Moderateur)
            {
                c.AjouterEquipe(e, nom);
            }
            else { return; }

        }
        /// <summary>
        /// Supprime une équipe dans une compétition a Poule
        /// </summary>
        /// <param name="c"></param>
        /// <param name="e"></param>
        /// <param name="nom"></param>
        public void SupprimerEquipeCompetitionAPoule(CompetitionAPoule c, Equipe e)
        {
            if (CurrentUser is Moderateur)
            {
                c.SupprimerEquipe(e);
            }
            else { return; }
        }
        /// <summary>
        /// Methode pour ajouter un joueur dans une équipe
        /// </summary>
        /// <param name="j"></param>
        /// <param name="e"></param>
        public void AjouterJoueur(Joueur j, Equipe e)
        {
            if(CurrentUser is Moderateur)
            {
                e.ajouterJoueur(j);
            }
            else { return; }
        }
        /// <summary>
        /// Methode pour supprimer un joueur de l'effectif d'une équipe
        /// </summary>
        /// <param name="j"></param>
        /// <param name="e"></param>
        public void SupprimerJoueur(Joueur j, Equipe e)
        {
            if(CurrentUser is Moderateur)
            {
                e.supprimerJoueur(j);
            }
            else { return; }
        }

        /// <summary>
        /// Methode permettant a un modératuer d'ajouter un ecompétition
        /// </summary>
        /// <param name="c"></param>
        public void AjouterCompetition(Competition c)
        {
            if (CurrentUser is Moderateur)
            {
                Competitions.Add(c);

            }
            else { return; }
        } 
        /// <summary>
        /// Methode permttant à un Moderateur de supprimer une compétition
        /// </summary>
        /// <param name="c"></param>
        public void SupprimerCompetition(Competition c)
        {
            if (CurrentUser is Moderateur)
            {
                Competitions.Remove(c);
            }
            else { return; }
        }
        /// <summary>
        /// Permet d'ajouter un résultat
        /// </summary>
        /// <param name="m"></param>
        /// <param name="r"></param>
        public void AjouterResultat(Match m, resultat res)
        {
            if (CurrentUser is Moderateur)
            {
                m.res.nbEssaiEquipeA = res.nbEssaiEquipeA;
                m.res.nbEssaiEquipeB = res.nbEssaiEquipeB;
                m.res.scoreEquipeA = res.scoreEquipeA;
                m.res.scoreEquipeB = res.scoreEquipeB;

                m.Joue = true;
            }
            else { return; }
        }

        /// <summary>
        /// Methode permettant d'ajouter un match
        /// </summary>
        /// <param name="equipeA"></param>
        /// <param name="equipeB"></param>
        /// <param name="journee"></param>
        /// <param name="c"></param>
        public void AjouterMatch(Equipe equipeA, Equipe equipeB, int journee, Competition c)
        {
            Match m = new Match(equipeA, equipeB, journee, c);
            c.Calendrier.Add(m);
        }


        /// <summary>
        /// Retourne l'effectif d'une équipe
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public IEnumerable<Joueur> getEffectifEquipe(Equipe e)
        {
            return e.Effectif;
        }

        

    }
}
