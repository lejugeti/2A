using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace DAL
{
    public interface IEmpruntRepository
    {
        List<Emprunt> GetAll();
        void Save(Emprunt emprunt);
    }
}
