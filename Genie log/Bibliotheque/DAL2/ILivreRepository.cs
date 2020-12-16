using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace DAL
{
    public interface ILivreRepository
    {
        List<Livre> GetAll();
        void Save(Livre livre);
    }
}
