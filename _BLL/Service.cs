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

        public void Interpolar(Red Red)
        {
            Repo.Interpolar(Red);
        }

        public Red GetXML()
        {
            return Repo.GetXML(null);
        }

    }
}
