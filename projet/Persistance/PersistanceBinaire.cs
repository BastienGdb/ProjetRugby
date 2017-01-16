using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using métier;


/*
namespace Persistance
{
    class PersistanceBinaire 
    {
        /// //////////////////////////////////// SAUVEGARDE /////////////////////////////////////////////////


        public void SauvegarderJoueur(Joueur j, BinaryWriter writer)
        {
            writer.Write(j.Nom);
            writer.Write(j.Prenom);
            writer.Write(j.Nationalite);
            writer.Write(j.Selection);
            writer.Write(j.Taille);
            writer.Write(j.Poids);
            writer.Write(j.Photo);
            writer.Write(Utils.PosteToString[j.PosteJoueur]);
            SauvegarderEquipe2(j.EquipeActuelle, writer);
            int i = j.Palmares.Count;
            writer.Write(i);
            foreach (Trophes t in j.Palmares)
            {
                SauvegarderTrophes(t, writer);
            }
            int k = j.Commentaires.Count;
            writer.Write(k);
            foreach (Commentaire c in j.Commentaires)
            {
                SauvegarderCommentaire(c, writer);
            }
        }

        public void SauvegarderTrophes(Trophes t, BinaryWriter writer)
        {
            writer.Write(t.NomTrophe);
            SauvegarderCompetition2(t.NomCompet, writer);
            SauvegarderEquipe2(t.EquipeGagnante, writer);
            writer.Write(t.Date);
        }

        public void SauvegarderCommentaire(Commentaire c, BinaryWriter writer)
        {
            SauvegarderUtilisateurInscrit(c.Auteur, writer);
            writer.Write(c.Date.ToString());
            writer.Write(c.Message);
        }

        public void SauvegarderUtilisateurInscrit(UtilisateurInscrit user, BinaryWriter writer)
        {
            writer.Write(user.Pseudo);
            writer.Write(user.MotDePasse);
            writer.Write(Utils.GradeToString[user.Grade]);
            writer.Write(user.NbCommEtJaime);
            writer.Write(user.Photo);
            writer.Write(Utils.SexeToString[user.Sexe]);
            SauvegarderEquipe2(user.EquipeFavorite, writer);
            SauvegarderEquipe2(user.EquipeNationalFavorite, writer);
        }

        public void SauvegarderModerateur(Moderateur admin, BinaryWriter writer)
        {
            writer.Write(admin.Pseudo);
            writer.Write(admin.MotDePasse);
            writer.Write(Utils.GradeToString[admin.Grade]);
            writer.Write(admin.NbCommEtJaime);
            writer.Write(admin.Photo);
            writer.Write(Utils.SexeToString[admin.Sexe]);
            SauvegarderEquipe2(admin.EquipeFavorite, writer);
            SauvegarderEquipe2(admin.EquipeNationalFavorite, writer);
        }

        public void SauvegarderEquipe(Equipe e, BinaryWriter writer)
        {
            writer.Write(e.Nom);
            writer.Write(Utils.TypeEquipeToString[e.Type]);
            writer.Write(e.Hymne);
            writer.Write(e.CheminLogo);
            writer.Write(e.Description);
            int i = e.Effectif.Count;
            writer.Write(i);
            foreach (Joueur j in e.Effectif)
            {
                SauvegarderJoueur(j, writer);
            }
            int k = e.Palmares.Count;
            writer.Write(k);
            foreach (Trophes t in e.Palmares)
            {
                SauvegarderTrophes(t, writer);
            }
            int l = e.Commentaires.Count;
            writer.Write(l);
            foreach (Commentaire c in e.Commentaires)
            {
                SauvegarderCommentaire(c, writer);
            }
        }
        public void SauvegarderMatch(Match m, BinaryWriter writer)
        {
            writer.Write(m.Journée);
            SauvegarderEquipe2(m.EquipeA, writer);
            SauvegarderEquipe2(m.EquipeB, writer);
            SauvegarderCompetition2(m.Competition, writer);
            writer.Write(m.res.scoreEquipeA);
            writer.Write(m.res.scoreEquipeB);
            writer.Write(m.res.nbEssaiEquipeA);
            writer.Write(m.res.nbEssaiEquipeB);
            writer.Write(m.Joue);
        }
        public void SauvegarderCompetition2(Competition c, BinaryWriter writer)
        {
            writer.Write(c.Nom);
            writer.Write(Utils.TypeEquipeToString[c.TypeEquipeParticipante]);
            writer.Write(c.Description);
            writer.Write(c.CheminLogo);
        }
        public void SauvegarderCompetition(Competition c, BinaryWriter writer)
        {

            if (c is CompetitionAPoule)
            {
                writer.Write("Competition à poules");
                SauvegarderCompetitionAPoule(c as CompetitionAPoule, writer);
            }
            else
            {
                writer.Write("Compet poule unique");
                SauvegarderCompetitionPouleUnique(c as CompetitionPouleUnique, writer);
            }
        }

        public void SauvegarderEquipe2(Equipe e, BinaryWriter writer)
        {
            writer.Write(e.Nom);
            writer.Write(Utils.TypeEquipeToString[e.Type]);
            writer.Write(e.Hymne);
            writer.Write(e.CheminLogo);
            writer.Write(e.Description);
        }

        public void SauvegarderCompetitionAPoule(CompetitionAPoule c, BinaryWriter writer)
        {
            writer.Write(c.Nom);
            writer.Write(Utils.TypeEquipeToString[c.TypeEquipeParticipante]);
            writer.Write(c.Description);
            writer.Write(c.CheminLogo);
            int i = c.Commentaires.Count;
            writer.Write(i);
            foreach (Commentaire com in c.Commentaires)
            {
                SauvegarderCommentaire(com, writer);
            }
            int j = c.Calendrier.Count;
            writer.Write(j);
            foreach (Match m in c.Calendrier)
            {
                SauvegarderMatch(m, writer);
            }

            int k = c.Poules.Count;
            writer.Write(k);
            foreach (CompetitionPouleUnique comp in c.Poules)
            {
                SauvegarderCompetitionPouleUnique(comp, writer);
            }
        }

        public void SauvegarderCompetitionPouleUnique(CompetitionPouleUnique c, BinaryWriter writer)
        {
            writer.Write(c.Nom);
            writer.Write(Utils.TypeEquipeToString[c.TypeEquipeParticipante]);
            writer.Write(c.Description);
            writer.Write(c.CheminLogo);
            int i = c.Commentaires.Count;
            writer.Write(i);
            foreach (Commentaire com in c.Commentaires)
            {
                SauvegarderCommentaire(com, writer);
            }
            int j = c.Calendrier.Count;
            writer.Write(j);
            foreach (Match m in c.Calendrier)
            {
                SauvegarderMatch(m, writer);
            }
            int k = c.classement.Count;
            writer.Write(k);
            foreach (KeyValuePair<Equipe, int> kvp in c.classement)
            {
                SauvegarderEquipe2(kvp.Key, writer);
                writer.Write(kvp.Value);
            }
            int l = c.Equipes.Count;
            writer.Write(l);
            foreach (Equipe e in c.Equipes)
            {
                SauvegarderEquipe(e, writer);
            }
        }

        public void Sauvegarder(Manager m)
        {

            using (FileStream fs = File.Create("Rugby.txt"))
            {
                BinaryWriter writer = new BinaryWriter(fs);
                int j = m.users.Count;
                writer.Write(j);
                foreach (Utilisateur u in m.users)
                {
                    SauvegarderUtilisateurInscrit(u as UtilisateurInscrit, writer);
                }
                int k = m.admins.Count;
                writer.Write(k);
                foreach (Moderateur mod in m.admins)
                {
                    SauvegarderModerateur(mod, writer);
                }
                int i = m.CompetitionsROC.Count;
                writer.Write(i);
                foreach (Competition c in m.CompetitionsROC)
                {
                    SauvegarderCompetition(c, writer);
                }

            }
        }

        ////////////////////////////////////////CHARGEMENT //////////////////////////////////////////////////

        public void Charger(Manager m)
        {
            using (FileStream fs = File.OpenRead("Rugby.txt"))
            {
                BinaryReader reader = new BinaryReader(fs);
                int i = reader.ReadInt32();
                for (int x = 0; x < i; x++)
                {
                    m.users.Add(ChargerUtilisateur(reader));
                }
                int j = reader.ReadInt32();
                for (int k = 0; k < j; k++)
                {
                    m.admins.Add(ChargerModerateur(reader));
                }
                int l = reader.ReadInt32();
                for (int n = 0; n < l; n++)
                {
                    m.Competitions.Add(ChargerCompetition(reader));
                }
            }
        }

        public UtilisateurInscrit ChargerUtilisateur(BinaryReader reader)
        {
            string Pseudo = reader.ReadString();
            string motDePasse = reader.ReadString();
            Grade grade = Utils.StringToGrade[reader.ReadString()];
            int NbJaime = reader.ReadInt32();
            string photo = reader.ReadString();
            Sexe sexe = Utils.StringToSexe[reader.ReadString()];
            Equipe equipeFavorite = ChargerEquipe2(reader);
            Equipe equipeNationalFavorite = ChargerEquipe2(reader);

            UtilisateurInscrit user = new UtilisateurInscrit(motDePasse, Pseudo, sexe, equipeFavorite, equipeNationalFavorite);
            user.Grade = grade;
            user.Photo = photo;
            user.NbCommEtJaime = NbJaime;
            return user;
        }

        public Moderateur ChargerModerateur(BinaryReader reader)
        {
            string Pseudo = reader.ReadString();
            string motDePasse = reader.ReadString();
            Grade grade = Utils.StringToGrade[reader.ReadString()];
            int NbJaime = reader.ReadInt32();
            string photo = reader.ReadString();
            Sexe sexe = Utils.StringToSexe[reader.ReadString()];
            Equipe equipeFavorite = ChargerEquipe2(reader);
            Equipe equipeNationalFavorite = ChargerEquipe2(reader);

            Moderateur admin = new Moderateur(motDePasse, Pseudo, sexe, equipeFavorite, equipeNationalFavorite);
            admin.Grade = grade;
            admin.Photo = photo;
            admin.NbCommEtJaime = NbJaime;
            return admin;
        }

        public Equipe ChargerEquipe2(BinaryReader reader)
        {
            string nom = reader.ReadString();
            TypeEquipe type = Utils.StringToTypeEquipe[reader.ReadString()];
            string hymne = reader.ReadString();
            string logo = reader.ReadString();
            string description = reader.ReadString();

            return new Equipe(nom, type, description, logo, hymne);
        }

        public Competition ChargerCompetition(BinaryReader reader)
        {

            if (reader.ReadString().Equals("Compet poule unique"))
            {
                return ChargerCompetitionAPouleUnique(reader);
            }
            else
            {
                return ChargerCompetitionAPoule(reader);
            }
        }
        public CompetitionPouleUnique ChargerCompetition2(BinaryReader reader)
        {
            string nom = reader.ReadString();
            TypeEquipe type = Utils.StringToTypeEquipe[reader.ReadString()];
            string description = reader.ReadString();
            string logo = reader.ReadString();
            CompetitionPouleUnique c = new CompetitionPouleUnique(description, type, nom, logo);
            return c;
        }

        public CompetitionAPoule ChargerCompetitionAPoule(BinaryReader reader)
        {
            string nom = reader.ReadString();
            TypeEquipe type = Utils.StringToTypeEquipe[reader.ReadString()];
            string description = reader.ReadString();
            string logo = reader.ReadString();
            CompetitionAPoule c = new CompetitionAPoule(description, type, nom, logo);
            int i = reader.ReadInt32();
            for (int z = 0; z < i; z++)
            {
                c.Commentaires.Add(ChargerCommentaire(reader));
            }
            int j = reader.ReadInt32();
            for (int x = 0; x < j; x++)
            {
                c.Calendrier.Add(ChargerMatch(reader));
            }
            int k = reader.ReadInt32();
            for (int l = 0; l < k; l++)
            {
                c.Poules.Add(ChargerCompetitionAPouleUnique(reader));
            }
            return c;
        }

        public CompetitionPouleUnique ChargerCompetitionAPouleUnique(BinaryReader reader)
        {
            string nom = reader.ReadString();
            TypeEquipe type = Utils.StringToTypeEquipe[reader.ReadString()];
            string description = reader.ReadString();
            string logo = reader.ReadString();
            CompetitionPouleUnique c = new CompetitionPouleUnique(description, type, nom, logo);
            int i = reader.ReadInt32();
            for (int z = 0; z < i; z++)
            {
                c.Commentaires.Add(ChargerCommentaire(reader));
            }
            int j = reader.ReadInt32();
            for (int y = 0; y < j; y++)
            {
                c.Calendrier.Add(ChargerMatch(reader));
            }
            int k = reader.ReadInt32();
            for (int x = 0; x < k; x++)
            {
                c.classement.Add(ChargerEquipe2(reader), reader.ReadInt32());
            }
            int l = reader.ReadInt32();
            for (int v = 0; v < l; v++)
            {
                c.Equipes.Add(ChargerEquipe(reader));
            }
            return c;
        }

        public Equipe ChargerEquipe(BinaryReader reader)
        {
            string nom = reader.ReadString();
            TypeEquipe type = Utils.StringToTypeEquipe[reader.ReadString()];
            string hymne = reader.ReadString();
            string logo = reader.ReadString();
            string description = reader.ReadString();

            Equipe e = new Equipe(nom, type, description, logo, hymne);

            int i = reader.ReadInt32();
            for (int z = 0; z < i; z++)
            {
                e.Effectif.Add(ChargerJoueur(reader));
            }
            int j = reader.ReadInt32();
            for (int y = 0; y < j; y++)
            {
                e.Palmares.Add(ChargerTrophe(reader));
            }
            int k = reader.ReadInt32();
            for (int x = 0; x < k; x++)
            {
                e.Commentaires.Add(ChargerCommentaire(reader));
            }
            return e;
        }

        public Joueur ChargerJoueur(BinaryReader reader)
        {
            string nom = reader.ReadString();
            string prenom = reader.ReadString();
            string nationalite = reader.ReadString();
            int nbselection = reader.ReadInt32();
            float taille = reader.ReadUInt64();
            float poids = reader.ReadUInt64();
            string photo = reader.ReadString();
            Poste poste = Utils.StringToPoste[reader.ReadString()];
            Equipe equipeActuelle = ChargerEquipe2(reader);
            Joueur j = new Joueur(nom, prenom, poids, taille, nationalite, nbselection, equipeActuelle, photo, poste);

            int i = reader.ReadInt32();
            for (int z = 0; z < i; z++)
            {
                j.Palmares.Add(ChargerTrophe(reader));
            }
            int l = reader.ReadInt32();
            for (int y = 0; y < l; y++)
            {
                j.Commentaires.Add(ChargerCommentaire(reader));
            }
            return j;
        }

        public Commentaire ChargerCommentaire(BinaryReader reader)
        {
            UtilisateurInscrit u = ChargerUtilisateur(reader);
            string date = reader.ReadString();
            DateTime dt = Convert.ToDateTime(date);
            string msg = reader.ReadString();
            return new Commentaire(msg, dt, u);
        }

        public Match ChargerMatch(BinaryReader reader)
        {
            int journee = reader.ReadInt32();
            Equipe equipeA = ChargerEquipe2(reader);
            Equipe equipeB = ChargerEquipe2(reader);
            CompetitionPouleUnique compet = ChargerCompetition2(reader);
            Match m = new Match(equipeA, equipeB, journee, compet);
            return m;
        }

       public Trophes ChargerTrophe(BinaryReader reader)
        {
            string nom = reader.ReadString();
            Competition nomCompet = ChargerCompetition2(reader);
            int date = reader.ReadInt32();
            Equipe equipeGagnante = ChargerEquipe2(reader);
            return new Trophes(nomCompet, date, nom, equipeGagnante);
        }
    }
}*/

