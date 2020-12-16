using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace DAL
{
    public interface IUtilisateurRepository
    {
        List<Utilisateur> GetAll();
        void Save(Utilisateur utilisateur);
    }
}
