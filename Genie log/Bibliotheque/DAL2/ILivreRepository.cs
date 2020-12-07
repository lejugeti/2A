using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace DAL
{
    interface ILivreRepository
    {
        List<Livre> GetAll();
        void Save(Livre livre);
    }
}
