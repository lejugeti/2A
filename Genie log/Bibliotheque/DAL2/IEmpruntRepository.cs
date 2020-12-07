using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace DAL
{
    interface IEmpruntRepository
    {
        List<Emprunt> GetAll();
        void Save(Emprunt emprunt);
    }
}
