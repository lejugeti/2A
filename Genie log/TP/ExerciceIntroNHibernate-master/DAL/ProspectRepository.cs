using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ProspectRepository : Repository, IProspectRepository 
    {

        public List<Prospect> GetAll()
        {
            return Session.Query<Prospect>().ToList();
        }

        public void Save(Prospect prospect)
        {
            Session.CreateQuery($"INSERT INTO prospect VALUES(0, {prospect.LastName}, {prospect.FirstName}, {prospect.Email}, {prospect.LastContact}, {prospect.Notes});");
        }
    }
}
