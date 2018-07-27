using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
    class DependancyInjection
    {
       public DependancyInjection()
        {
            //User usr = new User(new MySQLDal());

            User usr = new User(new SQLServerDal());
            usr.Add();
        }
    }

    interface Idal
    {
        void Add();
    }

    class User
    {
        Idal dal;
        public User(Idal iDalType)
        {
            dal = iDalType;
        }

        public bool IsValid
        {
            get { return true; }
        }

        public void Add()
        {
            if (IsValid)
            {
                dal.Add();
            }
        }

    }

    class MySQLDal : Idal
    {
        public void Add()
        {
            //do nothing
        }
    }

    class SQLServerDal : Idal
    {
        public void Add()
        {
            //do nothing
        }
    }
}
