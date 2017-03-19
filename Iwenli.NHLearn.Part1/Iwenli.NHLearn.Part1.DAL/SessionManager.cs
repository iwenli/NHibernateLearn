using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

namespace Iwenli.NHLearn.Part1.DAL
{
    public class SessionManager
    {
        private ISessionFactory _iSessionFactory;

        public SessionManager() {
            _iSessionFactory = new Configuration().Configure().BuildSessionFactory();
        } 
        public ISession GetSession() {
            return _iSessionFactory.OpenSession();
        }
    }
}
