using System;
using _DAL;
using _ENTITY;

namespace _BLL
{
    public class Service
    {
        Repository Repo;
        public Service()
        {
            Repo = new Repository();
        }

        public void Interpolar()
        {
            Repo.Interpolar();
        }

    }
}
