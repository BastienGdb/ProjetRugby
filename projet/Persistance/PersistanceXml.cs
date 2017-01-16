using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using métier;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;


namespace Persistance
{
    class PersistanceXml : IDataManager
    {


        public void EnregistreCompetitionAPoule(IEnumerable<Competition> compet)
        {

            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "CompetitionAPoule.xml");
            var serializer = new DataContractSerializer(typeof(List<CompetitionAPoule>),
                new Type[] { typeof(CompetitionAPoule) });
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            using (XmlWriter writer = XmlWriter.Create(xmlFile, settings))
            {
                serializer.WriteObject(writer, compet);
            }
        }

        public IEnumerable<Competition> ChargeCompetitionAPoule()
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "CompetitionAPoule.xml");
            var serializer = new DataContractSerializer(typeof(List<CompetitionAPoule>),
                new Type[] { typeof(CompetitionAPoule) });

            List<CompetitionAPoule> list;
            using (Stream s = File.OpenRead(xmlFile))
            {
                list = serializer.ReadObject(s) as List<CompetitionAPoule>;
            }
            return list;
        }


        public IEnumerable<Equipe> ChargeEquipeCompetition(string nomCompet)
        {
            List<CompetitionAPoule> competApoule = ChargeCompetitionAPoule() as List<CompetitionAPoule>;
            foreach(CompetitionAPoule c in competApoule)
            {
                foreach(CompetitionPouleUnique comp in c.Poules)
                {
                    if (comp.Nom.Equals(nomCompet))
                    {
                        return comp.Equipes;
                    }
                }
            }
            List<CompetitionPouleUnique> competPUnique = ChargeCompetitionPouleUnique() as List<CompetitionPouleUnique>;
            foreach(CompetitionPouleUnique CPU in competPUnique)
            {
                if (CPU.Nom.Equals(nomCompet))
                {
                    return CPU.Equipes;
                }
            }
            return null;
        }

        public void EnregistreCompetitionPouleUnique(IEnumerable<Competition> compet)
        {

            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "CompetitionPouleUnique.xml");
            var serializer = new DataContractSerializer(typeof(List<CompetitionPouleUnique>),
                new Type[] { typeof(CompetitionPouleUnique) });
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            using (XmlWriter writer = XmlWriter.Create(xmlFile, settings))
            {
                serializer.WriteObject(writer, compet);
            }
        }

        public IEnumerable<Competition> ChargeCompetitionPouleUnique()
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "CompetitionPouleUnique.xml");
            var serializer = new DataContractSerializer(typeof(List<CompetitionPouleUnique>),
                new Type[] { typeof(CompetitionPouleUnique) });

            List<CompetitionPouleUnique> list;
            using (Stream s = File.OpenRead(xmlFile))
            {
                list = serializer.ReadObject(s) as List<CompetitionPouleUnique>;
            }
            return list;
        }

        public IEnumerable<Competition> ChargeCompetition()
        {
            List<Competition> liste = new List<Competition>();
            liste.AddRange(ChargeCompetitionAPoule());
            liste.AddRange(ChargeCompetitionPouleUnique());
            return liste;
        }

        public void EnregistreCompetition(IEnumerable<Competition> compet)
        {
            List<CompetitionAPoule> listeCompetAPoule = new List<CompetitionAPoule>();
            List<CompetitionPouleUnique> listeCompetPouleUnique = new List<CompetitionPouleUnique>();

            foreach (Competition c in compet)
            {
                if (c is CompetitionAPoule)
                {
                    listeCompetAPoule.Add(c as CompetitionAPoule);
                }
                else
                {
                    listeCompetPouleUnique.Add(c as CompetitionPouleUnique);
                }
            }
        }

        public void EnregistreJoueur(IEnumerable<Joueur> joueurs)
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "AllJoueurs.xml");
            var serializer = new DataContractSerializer(typeof(List<Joueur>),
                new Type[] { typeof(Joueur) });
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            using (XmlWriter writer = XmlWriter.Create(xmlFile, settings))
            {
                serializer.WriteObject(writer, joueurs);
            }
        }

        public IEnumerable<Joueur> ChargerJoueurs()
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "AllJoueurs.xml");
            var serializer = new DataContractSerializer(typeof(List<Joueur>),
                new Type[] { typeof(Joueur) });

            List<Joueur> list;
            using (Stream s = File.OpenRead(xmlFile))
            {
                list = serializer.ReadObject(s) as List<Joueur>;
            }
            return list;
        }

        public IEnumerable<Joueur> ChargerJoueurEquipe(Equipe e)
        {
            List<Joueur> effectif = new List<Joueur>();
            List < Joueur >liste;
            liste = ChargerJoueurs() as List<Joueur>;
            foreach(Joueur j in liste)
            {
                if (j.EquipeActuelle.Equals(e))
                {
                    effectif.Add(j);
                }
            }
            return effectif;
        }

        public void EnregistrerMatchs(IEnumerable<Match> matchs)
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "AllMatchs.xml");
            var serializer = new DataContractSerializer(typeof(List<Match>),
                new Type[] { typeof(Match) });
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            using (XmlWriter writer = XmlWriter.Create(xmlFile, settings))
            {
                serializer.WriteObject(writer, matchs);
            }
        }

        public IEnumerable<Match> ChargeMatchs()
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "AllMatchs.xml");
            var serializer = new DataContractSerializer(typeof(List<Match>),
                new Type[] { typeof(Match) });

            List<Match> list;
            using (Stream s = File.OpenRead(xmlFile))
            {
                list = serializer.ReadObject(s) as List<Match>;
            }
            return list;
        }


        public void EnregistrerTrophe(IEnumerable<Trophes> trophes)
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "AllTrophes.xml");
            var serializer = new DataContractSerializer(typeof(List<Trophes>),
                new Type[] { typeof(Trophes) });
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            using (XmlWriter writer = XmlWriter.Create(xmlFile, settings))
            {
                serializer.WriteObject(writer, trophes);
            }
        }

        public IEnumerable<Trophes> ChargePalmares()
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "AllTrophes.xml");
            var serializer = new DataContractSerializer(typeof(List<Trophes>),
                new Type[] { typeof(Trophes) });

            List<Trophes> list;
            using (Stream s = File.OpenRead(xmlFile))
            {
                list = serializer.ReadObject(s) as List<Trophes>;
            }
            return list;
        }




        public IEnumerable<Equipe> ChargeEquipeNational()
        {
            List<Competition> compet = new List<Competition>();
            compet.AddRange(ChargeCompetition());
            List<Equipe> Nation = new List<Equipe>();
            foreach (Competition c in compet)
            {
                if (c.TypeEquipeParticipante == TypeEquipe.EquipeNational)
                {
                    Nation.AddRange(ChargeEquipeCompetition(c.Nom));
                }
            }
            return Nation;
        }

        public IEnumerable<Equipe> ChargeClub()
        {
            List<Competition> compet = new List<Competition>();
            compet.AddRange(ChargeCompetition());
            List<Equipe> Club = new List<Equipe>();
            foreach(Competition c in compet)
            {
                if (c.TypeEquipeParticipante == TypeEquipe.Club)
                {
                    Club.AddRange(ChargeEquipeCompetition(c.Nom));
                }
            }
            return Club;
        }

        public List<UtilisateurInscrit> ChargeUser()
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "Users.xml");
            var serializer = new DataContractSerializer(typeof(List<UtilisateurInscrit>),
                new Type[] { typeof(UtilisateurInscrit) });

            List<UtilisateurInscrit> list;
            using (Stream s = File.OpenRead(xmlFile))
            {
                list = serializer.ReadObject(s) as List<UtilisateurInscrit>;
            }
            return list;
        }

        public void EnregistreUser(IEnumerable<UtilisateurInscrit> users)
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string dirData = string.Format("{0}\\Persistance\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "Users.xml");
            var serializer = new DataContractSerializer(typeof(List<UtilisateurInscrit>),
                new Type[] { typeof(UtilisateurInscrit) });
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            using (XmlWriter writer = XmlWriter.Create(xmlFile, settings))
            {
                serializer.WriteObject(writer, users);
            }
        }

        public List<CompetitionPouleUnique> ChargePouleCompetition(string Nom)
        {
            List<CompetitionAPoule> competAPoule = new List<CompetitionAPoule>();
            competAPoule.AddRange(ChargeCompetitionAPoule() as List<CompetitionAPoule>);
            foreach(CompetitionAPoule c in competAPoule)
            {
                if (Nom.Equals(c.Nom))
                {
                    return c.Poules;
                }
            }
            return null;
        }
    }
}
