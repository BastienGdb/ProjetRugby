using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métier
{
    public interface IDataManager
    {
        IEnumerable<Competition> ChargeCompetition();
        void EnregistreCompetition(IEnumerable<Competition> compet);

        IEnumerable<Match> ChargeMatchs();
        IEnumerable<Trophes> ChargePalmares();

        IEnumerable<Equipe> ChargeEquipeNational();
        IEnumerable<Equipe> ChargeClub();

        List<UtilisateurInscrit> ChargeUser();
        void EnregistreUser(IEnumerable<UtilisateurInscrit> users);

        List<CompetitionPouleUnique> ChargePouleCompetition(String Nom);

        IEnumerable<Joueur> ChargerJoueurEquipe(Equipe e);
        IEnumerable<Equipe> ChargeEquipeCompetition(string nomCompet);


    }
}
