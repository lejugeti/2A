using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Domain;

namespace DAL
{
    public class EmpruntRepository : Repository, IEmpruntRepository
    {
        public List<Emprunt> GetAll()
        {
            return Session.Query<Emprunt>().ToList();
        }

        public void Save(Emprunt emprunt)
        {
            Session.SaveOrUpdate(emprunt);
            Session.Flush();
        }
    }
}
