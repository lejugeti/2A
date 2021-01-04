using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Domain;

namespace DAL
{
    public class LivreRepository : Repository, ILivreRepository
    {
        public List<Livre> GetAll()
        {
            return Session.Query<Livre>().ToList();
        }

        public void Save(Livre livre)
        {
            Session.SaveOrUpdate(livre);
            Session.Flush();
        }
    }
}
