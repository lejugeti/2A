using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Domain;

namespace DAL
{
    class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        public List<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }

        public void Save(Utilisateur utilisateur)
        {
            Session.SaveOrUpdate(utilisateur);
            Session.Flush();
        }
    }
}
