using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BLL
{
    public class Service
    {
        Repository Repo;
        public Service()
        {
            Repo = new Repository();
        }

        public Red GetXML()
        {
            return Repo.GetXML(null);
        }

    }
}
